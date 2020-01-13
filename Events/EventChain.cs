using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus.Events
{
    /// <summary>
    /// Handles logging and updating events for an instance of the AQA simulation.
    /// </summary>
    public static class EventChain
    {
        /// <summary>
        /// List of events that have occured during the run of the simulation.
        /// </summary>
        public static List<IEvent> Events { get; private set; } = new List<IEvent>();

        /// <summary>
        /// Adds an event to the chain, this event is then non-removeable and permanently recorded.
        /// </summary>
        public static void AddEvent(IEvent event_)
        {
            Events.Add(event_);
        }
    }
}
