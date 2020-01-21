using AQASkeletronPlus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus
{
    /// <summary>
    /// The "Balanced" edition of the simulation, fixed from the terrible AQA defaults.
    /// </summary>
    public class BalancedSimulation : Simulation
    {
        /// <summary>
        /// Base passthrough constructor.
        /// </summary>
        public BalancedSimulation(int width=-1, int height=-1, int startingHouseholds=-1, List<CompanyDefault> defaults=null) : base(width, height, startingHouseholds, defaults) { }
        
        /// <summary>
        /// Calculates visits from households based on both reputation AND distance AND type of company.
        /// </summary>
        protected override void CalculateVisitsFromHouseholds(List<double> cumulativeReputation, double totalReputation)
        {
            for (int i = 0; i < Settlement.NumHouseholds; i++)
            {
                Household thisHouse = Settlement.GetHouseholdAtIndex(i);

                //Does this household eat out?
                if (!thisHouse.EatsOut()) { continue; }

                //Pick a type of restaurant to eat at.
                CompanyType picked = PickRestaurantType();

                //Get outlets within a set boundary, of the selected type.
                double radius;
                switch (picked)
                {
                    case CompanyType.Family:
                        radius = Settings.Get.BalancedSim_TravelRadiusFamily;
                        break;
                    case CompanyType.FastFood:
                        radius = Settings.Get.BalancedSim_TravelRadiusFastFood;
                        break;
                    case CompanyType.NamedChef:
                        radius = Settings.Get.BalancedSim_TravelRadiusNamedChef;
                        break;
                    default:
                        //Unknown company type.
                        throw new Exception("Unknown company type to set travel radius for. Please update method.");
                }
                List<Outlet> outletsToPick = GetOutletsAround(thisHouse.Position, radius).Where(x => x.ParentCompany.Type == picked).ToList();

                //Are there any outlets to visit?
                if (outletsToPick.Count == 0)
                {
                    //Register a failed event.
                    EventChain.AddEvent(new FailedToEatOutEvent()
                    {
                        Origin = thisHouse.Position,
                        Radius = radius,
                        OutletType = picked
                    });

                    //This house is now done.
                    continue;
                }

                //Get the companies that these outlets have.
                List<Company> companiesNearMe = new List<Company>();
                foreach (var outlet in outletsToPick)
                {
                    if (companiesNearMe.FindIndex(x => x.Name == outlet.ParentCompany.Name) == -1)
                    {
                        companiesNearMe.Add(outlet.ParentCompany);
                    }
                }

                //Randomly roll on their reputation.
                double totalRep = companiesNearMe.Sum(x => x.Reputation);
                List<double> cumulativeRep = companiesNearMe.Select(x => x.Reputation).CumulativeSum().ToList();
                double randomSelection = Random.NextDouble() * totalRep;
                Company selected = null;
                
                for (int k = 0; k < cumulativeRep.Count; k++)
                {
                    if (randomSelection < cumulativeRep[k])
                    {
                        selected = companiesNearMe[k];
                        break;
                    }
                }

                //Successfully selected a company, visit!
                selected.AddVisitToNearestOutlet(thisHouse.Position, ref base.visits);
            }
        }

        /// <summary>
        /// Returns a list of outlets around a given position.
        /// </summary>
        /// <returns></returns>
        public List<Outlet> GetOutletsAround(Vector2 position, double radius)
        {
            List<Outlet> valid = new List<Outlet>();

            //For every outlet, get distance between points. Within radius? Add.
            foreach (var company in Companies)
            {
                //Set the willing distance to travel based on company type.
                foreach (var outlet in company.outlets)
                {
                    if (position.DistanceTo(outlet.Position) < radius) { valid.Add(outlet); }
                }
            }

            return valid;
        }

        /// <summary>
        /// Picks a type of restaurant for the households to eat at.
        /// </summary>
        /// <returns></returns>
        private CompanyType PickRestaurantType()
        {
            double tracker = 0.0;
            List<double> thresholds = new List<double>();

            //Add all the thresholds.
            tracker += Settings.Get.BalancedSim_PickChanceFastFood; thresholds.Add(tracker);
            tracker += Settings.Get.BalancedSim_PickChanceFamily; thresholds.Add(tracker);
            tracker += Settings.Get.BalancedSim_PickChanceNamedChef; thresholds.Add(tracker);

            //Calculate. This has to be done with "if" blocks for now, clean up later?
            double randomPick = Random.NextDouble() * tracker;
            if (randomPick < thresholds[0])
            {
                return CompanyType.FastFood;
            }
            else if (randomPick < thresholds[1] && randomPick > thresholds[0])
            {
                return CompanyType.Family;
            }
            else if (randomPick < thresholds[2] && randomPick > thresholds[1])
            {
                return CompanyType.NamedChef;
            }
            else
            {
                throw new Exception("Unexpected company type detected, update this method to support it.");
            }
        }

        /// <summary>
        /// Processes a change in fuel cost more fairly compared to default settings.
        /// </summary>
        protected override void ProcessChangeFuelCostEvent()
        {
            //Check if fuel price increases or decreases, get by how much.
            bool increases = (Random.NextDouble() < Settings.Get.ChanceOfFuelPriceIncrease);
            double amt = Random.Next(1, 5) / 10.0;

            //Which company is it for?
            int companyIndex = Random.Next(0, Companies.Count - 1);

            //Complete the change, log.
            if (!increases) { amt = -amt; }
            Companies[companyIndex].ChangeFuelCostBy(amt, Settings.Get.BalancedSim_FuelCostCap);

            EventChain.AddEvent(new FuelCostChangeEvent()
            {
                AmountBy = amt,
                Company = Companies[companyIndex].Name,
            });
        }
    }
}
