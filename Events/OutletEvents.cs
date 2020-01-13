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
    }

    public class OutletProfitEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.OutletProfit;
        public double ProfitLoss;
    }
}
