﻿using AQASkeletronPlus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus
{
    /// <summary>
    /// Represents a single AQA skeleton simulation.
    /// </summary>
    public class Simulation
    {
        //The random number generator used throughout the simulation. Securely seeded.
        public static RandomWrapper Random = new RandomWrapper(Guid.NewGuid().GetHashCode());

        //Private properties of the simulation.
        private List<Company> companies = new List<Company>();
        private Settlement settlement;
        private double currentFuelCost;

        /// <summary>
        /// Constructs a simulation, with either default or user specified company templates.
        /// </summary>
        public Simulation(int width=-1, int height=-1, int startingHouseholds=-1, List<CompanyDefault> companyTemps = null)
        {
            //Create a new settlement.
            settlement = new Settlement(width, height);

            //Set default locals.
            currentFuelCost = Settings.Get.FuelCostPerTile;

            //Were the companies to use specified?
            if (companyTemps == null)
            {
                //Load defaults.
                companyTemps = Settings.DefaultCompanies;
            }

            //Load every company into the simulation.
            foreach (var company in companyTemps)
            {
                companies.Add(new Company(settlement,
                                         company.Name,
                                         company.Type,
                                         company.StartingBalance,
                                         settlement.GetFreeRandomPosition(),
                                         currentFuelCost,
                                         Settings.Get.BaseCostForDelivery
                ));

                //Add outlets for that company at random positions.
                for (int i = 0; i < company.StartingOutlets; i++)
                {
                    companies.Last().OpenOutlet(settlement.GetFreeRandomPosition());
                }
            }
        }

        /// <summary>
        /// Ends the current day, and moves onto the next one.
        /// </summary>
        public void ProcessDayEnd()
        {
            //Gather the cumulative reputation for all companies.
            double totalReputation = 0;
            List<double> cumulativeReputation = new List<double>();
            foreach (var c in companies)
            {
                totalReputation += c.Reputation;
                cumulativeReputation.Add(totalReputation);
            }

            //Loop over each house and see if they eat out, and if so, where.
            for (int i=0; i<settlement.NumHouseholds; i++)
            {
                Household thisHousehold = settlement.GetHouseholdAtIndex(i);
                
                //Do they eat out?
                if (!thisHousehold.EatsOut()) { continue; }

                //Yes, they do, but where? Calculate based on nearest outlet and reputation.
                double randomRepNum = Random.NextDouble() * totalReputation;
                int current = 0;
                while (current < cumulativeReputation.Count)
                {
                    //Is this company's reputation sufficient for this household to eat there?
                    if (randomRepNum < cumulativeReputation[current])
                    {
                        //Yes, eat then break.
                        companies[current].AddVisitToNearestOutlet(thisHousehold.Position);
                        break;
                    }
                    current++;
                }
            }

            //Process the end of the day for each company.
            foreach (var c in companies)
            {
                c.ProcessDayEnd();
            }

            //Choose the random events that will occur at this day end.
            double eventRand = Random.NextDouble();
            if (eventRand < Settings.Get.BaseChanceOfRandomEvents)
            {
                //Random household addition event.
                eventRand = Random.NextDouble();
                if (eventRand < Settings.Get.ChanceOfAddHouseholdsEvent)
                {
                    ProcessAddHouseholdsEvent();
                }

                //Random fuel cost change event.
                eventRand = Random.NextDouble();
                if (eventRand < Settings.Get.ChanceOfChangeFuelCostEvent)
                {
                    ProcessChangeFuelCostEvent();
                }

                //Random reputation change event.
                eventRand = Random.NextDouble();
                if (eventRand < Settings.Get.ChanceOfReputationChangeEvent)
                {
                    ProcessChangeReputationEvent();
                }

                //Random daily cost change event.
                eventRand = Random.NextDouble();
                if (eventRand < Settings.Get.ChanceOfCostChangeEvent)
                {
                    ProcessCostChangeEvent();
                }
            }

            //Process households leaving for the day.
            settlement.ProcessLeavers();
        }

        /// <summary>
        /// Changes a random cost for a single company by a random amount.
        /// </summary>
        private void ProcessCostChangeEvent()
        {
            //How much to change by, should it go up or down, and which company should it be applied to?
            bool increases = (Random.NextDouble() < Settings.Get.ChanceOfCostIncrease);
            double amt = Random.NextDouble() * 10.0;
            if (!increases) { amt = -amt; }
            int companyIndex = Random.Next(0, companies.Count - 1);

            //Figured it out, determine which cost to increase/decrease.
            int costType = Random.Next(0, 1);
            string costTypeStr;
            if (costType == 0)
            {
                //Change the daily cost for the company.
                costTypeStr = "daily cost";
                amt *= 2;
                companies[companyIndex].ChangeDailyCostBy(amt);
            }
            else
            {
                //Change the average meal costs for a company.
                costTypeStr = "average meal cost";
                companies[companyIndex].ChangeAvgMealCostBy(amt);
            }

            //Log as an event.
            EventChain.AddEvent(new CostChangeEvent()
            {
                AmountBy = amt,
                Company = companies[companyIndex].Name,
                CostType = costTypeStr
            });
        }

        /// <summary>
        /// Changes a single company's reputation randomly.
        /// </summary>
        private void ProcessChangeReputationEvent()
        {
            //Calculate the amount, and whether it's increasing or decreasing.
            bool increases = (Random.NextDouble() < Settings.Get.ChanceOfReputationIncrease);
            double amt = Random.Next(1, 10) / 10.0;
            if (!increases) { amt = -amt; }

            //Which company is this for?
            int companyIndex = Random.Next(0, companies.Count - 1);

            //Apply and log.
            companies[companyIndex].ChangeReputationBy(amt);

            EventChain.AddEvent(new ReputationChangeEvent()
            {
                Company = companies[companyIndex].Name,
                AmountBy = amt
            });
        }

        /// <summary>
        /// Changes the price of fuel randomly.
        /// </summary>
        private void ProcessChangeFuelCostEvent()
        {
            //Check if fuel price increases or decreases, get by how much.
            bool increases = (Random.NextDouble() < Settings.Get.ChanceOfFuelPriceIncrease);
            double amt = Random.Next(1, 10) / 10.0;

            //Which company is it for?
            int companyIndex = Random.Next(0, companies.Count - 1);

            //Complete the change, log.
            if (!increases) { amt = -amt; }
            companies[companyIndex].ChangeFuelCostBy(amt);

            EventChain.AddEvent(new FuelCostChangeEvent()
            {
                AmountBy = amt,
                Company = companies[companyIndex].Name,
            });
        }

        /// <summary>
        /// Adds a random number of households (default 1-5) to the settlement.
        /// </summary>
        private void ProcessAddHouseholdsEvent()
        {
            int newHouseholds = Random.Next(Settings.Get.MinNewHouseholds, Settings.Get.MaxNewHouseholds);
            int stored = newHouseholds;
            while (newHouseholds > 0)
            {
                settlement.AddHousehold();
                newHouseholds--;
            }

            //Log to the event chain.
            EventChain.AddEvent(new AddHouseholdsEvent()
            {
                NumHouses = stored
            });
        }
    }
}
