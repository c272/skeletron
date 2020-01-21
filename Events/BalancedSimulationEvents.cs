using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus.Events
{
    /// <summary>
    /// Represents a household failing to eat out because no households are nearby.
    /// </summary>
    public class FailedToEatOutEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.FailedToEatOut;
        public Vector2 Origin;
        public double Radius;
        public CompanyType OutletType;

        public string Stringify()
        {
            return "Household at " + Origin.ToString() + " couldn't eat out, since there were no outlets of type " + OutletType.ToString() + " nearby (within " + Radius + " units).";
        }
    }
}
