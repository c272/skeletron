using AQASkeletronPlus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus
{
    /// <summary>
    /// A generic settlement in AQA Skeleton simulation.
    /// </summary>
    public class Settlement
    {
        //Public accessors for the settlement.
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public int StartingHouseholds { get; protected set; }
        public int NumHouseholds
        {
            get
            {
                return Households.Count;
            }
        }

        //Inaccessible private fields.
        private List<Vector2> Occupied = new List<Vector2>();
        private List<Household> Households = new List<Household>();

        public Settlement(int width = -1, int height = -1, int startNoHouseholds = -1)
        {
            if (width == -1 && height == -1) { width = Settings.Get.DefaultSettlementWidth; height = Settings.Get.DefaultSettlementHeight; }
            if (startNoHouseholds == -1) { startNoHouseholds = Settings.Get.DefaultSettlementStartingHouses; }

            Width = Width;
            Height = Height;
            StartingHouseholds = startNoHouseholds;

            if (startNoHouseholds > Width * Height) { throw new Exception("Too many starting houses (larger than grid)."); }
            CreateHouseholds(startNoHouseholds);
        }

        /// <summary>
        /// Creates a given number of households in the settlement.
        /// </summary>
        public void CreateHouseholds(int num)
        {
            for (int i=0; i<num; i++)
            {
                AddHousehold();
            }
        }

        /// <summary>
        /// Adds a single household to the settlement.
        /// </summary>
        public void AddHousehold()
        {
            //Check a household can actually be added.
            if (Households.Count >= Width * Height) { return; }

            Vector2 housePos = GetFreeRandomPosition();
            Households.Add(new Household(housePos));
        }

        /// <summary>
        /// Returns the household from the settlement at a given index.
        /// </summary>
        public Household GetHouseholdAtIndex(int i)
        {
            return Households[i];
        }

        /// <summary>
        /// Process all of the leavers from the settlement.
        /// </summary>
        public void ProcessLeavers()
        {
            int removed = 0;
            for (int i=0; i<Households.Count; i++)
            {
                //2% chance for a household to leave by default.
                if (Simulation.Random.NextDouble() < Settings.Get.ChanceOfHouseholdLeaving)
                {
                    Households.RemoveAt(i);
                    i--;
                    removed++;
                }
            }

            //Log to event chain.
            EventChain.AddEvent(new HouseholdLeavingEvent()
            {
                NumHouseholds = removed
            });
        }

        /// <summary>
        /// Returns a random position on the settlement that is not occupied.
        /// </summary>
        /// <returns></returns>
        public Vector2 GetFreeRandomPosition()
        {
            //Are there *any* free spots?
            if (Occupied.Count == Width * Height) { return null; }

            Vector2 pos = null;
            while (pos == null || IsOccupied(pos))
            {
                //Generate a random number (0->width-1, 0->height-1).
                int x = Simulation.Random.Next(0, Width - 1);
                int y = Simulation.Random.Next(0, Height - 1);

                //Set the vector.
                pos = new Vector2(x, y);
            }

            return pos;
        }

        /// <summary>
        /// Checks if a tile on the settlement is occupied.
        /// </summary>
        public bool IsOccupied(Vector2 pos)
        {
            if (pos.x > Width || pos.x < 0) { throw new Exception("Position to check out of X bounds."); }
            if (pos.y > Height || pos.y < 0) { throw new Exception("Position to check out of Y bounds."); }

            return Occupied.Contains(pos);
        }

        /// <summary>
        /// Reserves a space on the settlement grid as in use.
        /// </summary>
        public void Occupy(Vector2 pos)
        {
            if (Occupied.Contains(pos)) { throw new Exception("This position is already occupied, cannot occupy again."); }
            Occupied.Add(pos);
        }

        /// <summary>
        /// Unreserves a previously reserved space on the grid.
        /// </summary>
        public void Unoccupy(Vector2 pos)
        {
            Occupied.RemoveAll(x => x.x == pos.x && x.y == pos.y);
        }
    }
}
