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

        public string Stringify()
        {
            return NumHouses + " houses moved into the settlement.";
        }
    }

    /// <summary>
    /// Represents a single randomized fuel cost change for a company.
    /// </summary>
    public class FuelCostChangeEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.FuelCostChange;
        public double AmountBy;
        public string Company;

        public string Stringify()
        {
            return "Fuel cost for company '" + Company + "' has altered by £" + AmountBy + ".";
        }
    }

    /// <summary>
    /// Represents a single random change in reputation for a company.
    /// </summary>
    public class ReputationChangeEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.ReputationChange;
        public double AmountBy;
        public string Company;

        public string Stringify()
        {
            return "Reputation for company '" + Company + "' has altered by £" + AmountBy + ".";
        }
    }

    /// <summary>
    /// Represents a single random change in cost for a company.
    /// </summary>
    public class CostChangeEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.CostChange;
        public double AmountBy;
        public string Company;
        public string CostType;

        public string Stringify()
        {
            return "Cost type '" + CostType + "' for company '" + Company + "' has altered by £" + AmountBy + ".";
        }
    }

    public class HouseholdLeavingEvent : IEvent
    {
        public EventType Type { get; set; } = EventType.HouseholdLeaving;
        public int NumHouseholds;

        public string Stringify()
        {
            return NumHouseholds + " households have left the settlement.";
        }
    }
}
