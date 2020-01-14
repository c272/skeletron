using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus.Events
{
    /// <summary>
    /// Represents a single food truck being moved one square.
    /// </summary>
    public class FoodTruckMoveEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.FoodTruckMove;
        public Vector2 From;
        public Vector2 To;
        public string Company;

        public string Stringify()
        {
            return "Food truck for company '" + Company + "' moved from position " + From.ToString() + " to " + To.ToString() + ".";
        }
    }

    /// <summary>
    /// Describes a single outlet's profit for the day being calculated.
    /// </summary>
    public class OutletProfitEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.OutletProfit;
        public double ProfitLoss;
        public string Company;

        public string Stringify()
        {
            return "Outlet for company '" + Company + "' calculated a profit/loss of £" + ProfitLoss + " for the day.";
        }
    }

    /// <summary>
    /// Describes a single visit to an  outlet by a household.
    /// </summary>
    public class VisitOutletEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.VisitOutlet;
        public Vector2 Household;
        public string Company;
        public Vector2 OutletPos;

        public string Stringify()
        {
            return "Household " + Household.ToString() + " visited outlet for company '" + Company + "' at position " + OutletPos.ToString() + ".";
        }
    }
}
