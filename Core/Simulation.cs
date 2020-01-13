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
        public static MapPanel Panel = null;

        //Private properties of the simulation.
        private List<Company> companies = new List<Company>();
        private Settlement settlement;

        /// <summary>
        /// Constructs a simulation, with an optional graphical map panel.
        /// </summary>
        public Simulation(MapPanel p=null, int width=-1, int height=-1, int startingHouseholds=-1, int startingCompanies=5)
        {
            //Create a new settlement.
            settlement = new Settlement(width, height);

            //todo
        }
    }
}
