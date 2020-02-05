using AQASkeletronPlus.Events;
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
        public List<Company> Companies { get; protected set; } = new List<Company>();
        public Settlement Settlement { get; protected set; }
        private double currentFuelCost;
        protected List<Tuple<Vector2, Vector2>> visits = new List<Tuple<Vector2, Vector2>>();
        public int DaysElapsed { get; protected set; } = 0;
        public List<Company> CompaniesClosedYesterday = new List<Company>();

        //The map panel assigned to this simulation.
        private MapPanel map = null;

        /// <summary>
        /// Constructs a simulation, with either default or user specified company templates.
        /// </summary>
        public Simulation(int width=-1, int height=-1, int startingHouseholds=-1, List<CompanyDefault> companyTemps = null)
        {
            //Create a new settlement.
            Settlement = new Settlement(width, height, startingHouseholds);

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
                AddCompanyFromDefault(company);
            }
        }

        /// <summary>
        /// Adds a company to the simulation from a CompanyDefault.
        /// </summary>
        public void AddCompanyFromDefault(CompanyDefault company)
        {
            Companies.Add(new Company(Settlement,
                                         company.Name,
                                         company.Type,
                                         company.StartingBalance,
                                         Settlement.GetFreeRandomPosition(),
                                         currentFuelCost,
                                         Settings.Get.BaseCostForDelivery
                ));

            //Add outlets for that company at random positions.
            for (int i = 0; i < company.StartingOutlets; i++)
            {
                Companies.Last().OpenOutlet(Settlement.GetFreeRandomPosition());
            }
        }

        /// <summary>
        /// Sets the map for this simulation instance.
        /// </summary>
        public void SetMap(MapPanel map_)
        {
            //Change the map, update with current setup.
            map = map_;
            map.Clear();
            map.AddBuildings(GetBuildingCoordinates());
        }

        /// <summary>
        /// Ends the current day, and moves onto the next one.
        /// </summary>
        public void ProcessDayEnd()
        {
            //Gather the cumulative reputation for all companies.
            double totalReputation = 0;
            List<double> cumulativeReputation = new List<double>();
            CompaniesClosedYesterday = new List<Company>();
            foreach (var c in Companies)
            {
                totalReputation += c.Reputation;
                cumulativeReputation.Add(totalReputation);
            }

            //Loop over each house and see if they eat out, and if so, where.
            visits = new List<Tuple<Vector2, Vector2>>();
            CalculateVisitsFromHouseholds(cumulativeReputation, totalReputation);

            //Process the end of the day for each company.
            for (int i=0; i<Companies.Count; i++)
            {
                Companies[i].ProcessDayEnd();

                //Is the company bankrupt?
                if (Companies[i].Balance < 0)
                {
                    //Bankrupt the company, remove from list (log event).
                    EventChain.AddEvent(new BankruptcyEvent()
                    {
                        CompanyName = Companies[i].Name,
                        DaysLasted = DaysElapsed
                    });
                    CompaniesClosedYesterday.Add(Companies[i]);
                    Companies.RemoveAt(i);
                    i--;
                }
            }

            //Only do random events if companies still exist.
            if (Companies.Count > 0)
            {

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
            }

            //Process households leaving for the day.
            Settlement.ProcessLeavers();

            //End this day's event chain, and start a new one.
            EventChain.Refresh();

            //Draw the new map with updated positions and tracers, if the map is enabled.
            UpdateMap();
            DaysElapsed++;
        }

        /// <summary>
        /// Calculates visits for each household based on reputation.
        /// </summary>
        protected virtual void CalculateVisitsFromHouseholds(List<double> cumulativeReputation, double totalReputation)
        {
            for (int i = 0; i < Settlement.NumHouseholds; i++)
            {
                Household thisHousehold = Settlement.GetHouseholdAtIndex(i);

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
                        Companies[current].AddVisitToNearestOutlet(thisHousehold.Position, ref visits);
                        break;
                    }
                    current++;
                }
            }
        }

        /// <summary>
        /// Deletes a company from the simulation.
        /// </summary>
        public void DeleteCompany(string companyName)
        {
            Companies.RemoveAll(x => x.Name == companyName);
        }

        /// <summary>
        /// Manual handler to update the map with fresh simulation data.
        /// </summary>
        public void UpdateMap()
        {
            if (map != null)
            {
                map.Clear();
                map.AddBuildings(GetBuildingCoordinates());
                map.SetTracers(visits);
            }
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
            int companyIndex = Random.Next(0, Companies.Count - 1);

            //Figured it out, determine which cost to increase/decrease.
            int costType = Random.Next(0, 1);
            string costTypeStr;
            if (costType == 0)
            {
                //Change the daily cost for the company.
                costTypeStr = "daily cost";
                amt *= 2;
                Companies[companyIndex].ChangeDailyCostBy(amt);
            }
            else
            {
                //Change the average meal costs for a company.
                costTypeStr = "average meal cost";
                Companies[companyIndex].ChangeAvgMealCostBy(amt);
            }

            //Log as an event.
            EventChain.AddEvent(new CostChangeEvent()
            {
                AmountBy = amt,
                Company = Companies[companyIndex].Name,
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
            int companyIndex = Random.Next(0, Companies.Count - 1);

            //Apply and log.
            Companies[companyIndex].ChangeReputationBy(amt);

            EventChain.AddEvent(new ReputationChangeEvent()
            {
                Company = Companies[companyIndex].Name,
                AmountBy = amt
            });
        }

        /// <summary>
        /// Changes the price of fuel randomly.
        /// </summary>
        protected virtual void ProcessChangeFuelCostEvent()
        {
            //Check if fuel price increases or decreases, get by how much.
            bool increases = (Random.NextDouble() < Settings.Get.ChanceOfFuelPriceIncrease);
            double amt = Random.Next(1, 10) / 10.0;

            //Which company is it for?
            int companyIndex = Random.Next(0, Companies.Count - 1);

            //Complete the change, log.
            if (!increases) { amt = -amt; }
            Companies[companyIndex].ChangeFuelCostBy(amt);

            EventChain.AddEvent(new FuelCostChangeEvent()
            {
                AmountBy = amt,
                Company = Companies[companyIndex].Name,
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
                Settlement.AddHousehold();
                newHouseholds--;
            }

            //Log to the event chain.
            EventChain.AddEvent(new AddHouseholdsEvent()
            {
                NumHouses = stored
            });
        }

        /// <summary>
        /// Returns all buildings on the settlement as a list of coordinates.
        /// </summary>
        /// <returns></returns>
        public List<Building> GetBuildingCoordinates()
        {
            List<Building> buildings = new List<Building>();

            //Add all the outlets.
            foreach (var company in Companies)
            {
                foreach (var outlet in company.outlets)
                {
                    buildings.Add(new Building()
                    {
                        Position = outlet.Position,
                        Type = BuildingType.Outlet,
                        Name = company.Name, //Make sure the company name is present!
                        Outlet = outlet
                    });
                }
            }

            //Add all the houses.
            foreach (var house in Settlement.Households)
            {
                buildings.Add(new Building()
                {
                    Position = house.Position,
                    Type = BuildingType.Household
                });
            }

            //Return.
            return buildings;
        }
    }
}
