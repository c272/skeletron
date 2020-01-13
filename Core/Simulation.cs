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
        public static Random Random = new Random(Guid.NewGuid().GetHashCode());

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

        }
    }
}
