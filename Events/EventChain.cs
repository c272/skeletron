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
        /// List of event chains that have been archived. Limited to 50 long.
        /// </summary>
        private static List<List<IEvent>> SavedChains = new List<List<IEvent>>();

        /// <summary>
        /// Adds an event to the chain, this event is then non-removeable and permanently recorded.
        /// </summary>
        public static void AddEvent(IEvent event_)
        {
            Events.Add(event_);
        }

        /// <summary>
        /// Resets the current event chain to blank, and saves the previous into the saved list.
        /// </summary>
        public static void Refresh()
        {
            SavedChains.Add(Events);
            if (SavedChains.Count > 50) { SavedChains.RemoveAt(0); }
            Events = new List<IEvent>();
        }

        /// <summary>
        /// Gets an event chain, specified by how long ago it was. "0" is the current chain.
        /// </summary>
        public static List<IEvent> GetChain(int numChainsAgo)
        {
            //Is the chain valid?
            if (numChainsAgo > 50) { return null; }
            if (numChainsAgo < 0) { throw new Exception("Cannot get future chains (less than 0 chains ago)."); }
            
            //This one.
            if (numChainsAgo == 0) { return Events; }

            //Not this one, so morph to index.
            int index = SavedChains.Count - numChainsAgo;
            if (index > SavedChains.Count - 1 || index < 0) { return null; }
            return SavedChains[index];
        }
    }
}
