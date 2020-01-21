using AQASkeletronPlus.Events;
using System;

namespace AQASkeletronPlus
{
    /// <summary>
    /// Represents a single outlet in a settlement inside the AQA simulation.
    /// </summary>
    public class Outlet
    {
        //Public accessors for this outlet.
        public Vector2 Position { get; protected set; }
        public int Capacity { get; protected set; }
        public double DailyCost { get; protected set; }
        public Company ParentCompany { get; protected set; }

        //The settlement which this outlet was created on.
        protected Settlement settlement;
        protected int visitsToday = 0;

        /// <summary>
        /// The number of households who visited this outlet yesterday.
        /// </summary>
        public int VisitedYesterday { get; protected set; } = 0;

        public Outlet(Settlement s, Company parent, Vector2 position, int capacity, double dailyCost)
        {
            Position = position;
            Capacity = capacity;
            DailyCost = dailyCost;
            ParentCompany = parent;
            settlement = s;
            settlement.Occupy(position);
        }

        /// <summary>
        /// Visit the outlet (increments visits for today).
        /// </summary>
        public void Visit(Vector2 origin)
        {
            visitsToday++;

            //Log event.
            EventChain.AddEvent(new VisitOutletEvent()
            {
                Company = ParentCompany.Name,
                Household = origin,
                OutletPos = Position
            });
        }

        /// <summary>
        /// Calculates the daily profit for this outlet (positive or negative).
        /// </summary>
        public double GetDailyProfit(double avgCostPerMeal, double avgPricePerMeal)
        {
            return (avgPricePerMeal - avgCostPerMeal) * visitsToday - DailyCost;
        }

        /// <summary>
        /// Processes the end of the day for this outlet.
        /// </summary>
        public void ProcessDayEnd()
        {
            //Reset the visits for the day.
            VisitedYesterday = visitsToday;
            visitsToday = 0;
        }
    }
}