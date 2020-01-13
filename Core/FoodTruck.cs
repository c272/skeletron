using AQASkeletronPlus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus
{
    /// <summary>
    /// Represents a single food truck in the AQA simulation.
    /// </summary>
    public class FoodTruck : Outlet
    {
        public FoodTruck(Settlement s, Vector2 startPos, int capacity) : base(s, startPos, capacity)
        {

        }

        /// <summary>
        /// Moves one square in a random direction.
        /// </summary>
        public void Move()
        {
            //Calculate a random direction.
            int x = base.Position.x;
            int y = base.Position.y;
            int rand = Simulation.Random.Next(0, 3);
            switch (rand)
            {
                case 0: x--; break;
                case 1: x++; break;
                case 2: y--; break;
                case 3: y++; break;
            }

            //Clamp inside the settlement.
            x.Clamp(0, base.settlement.Width - 1);
            y.Clamp(0, base.settlement.Height - 1);

            //Is the position occupied? Don't move.
            if (settlement.IsOccupied(new Vector2(x, y))) { return; }

            //Set position, update on settlement too.
            Vector2 old = Position;
            Position = new Vector2(x, y);
            settlement.Unoccupy(old);
            settlement.Occupy(Position);

            //Log the event.
            EventChain.AddEvent(new FoodTruckMoveEvent()
            {
                From = old,
                To = Position
            });
        }
    }
}
