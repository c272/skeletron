using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus.Events
{
    /// <summary>
    /// Represents a single randomized household addition to the settlement.
    /// </summary>
    public class AddHouseholdsEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.AddHouseholds;
        public int NumHouses;
    }
}
