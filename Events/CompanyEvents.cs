using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus.Events
{
    /// <summary>
    /// Represents an outlet being created.
    /// </summary>
    public class OutletCreateEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.OutletCreate;
        public Vector2 Position;
        public int Capacity;

        public string Stringify()
        {
            return "Outlet created at position " + Position.ToString() + ", with capacity " + Capacity + ".";
        }
    }

    /// <summary>
    /// Represents a delivery being made to all a company's outlets.
    /// </summary>
    public class DeliveryEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.Delivery;
        public double Cost;
        public string CompanyName;

        public string Stringify()
        {
            return "Delivery made for company '" + CompanyName + "', at a cost of £" + Cost + ".";
        }
    }
}
