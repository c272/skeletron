using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus.Events
{
    /// <summary>
    /// Describes a single event within AQA Skeletron.
    /// </summary>
    public interface IEvent
    {
        EventType Type { get; set; }
        string Stringify();
    }

    /// <summary>
    /// Describes all types of event that occur within the simulation.
    /// </summary>
    public enum EventType
    {
        OutletCreate,
        FoodTruckMove,
        OutletProfit,
        Delivery,
        VisitOutlet,
        AddHouseholds,
        FuelCostChange,
        ReputationChange,
        CostChange,
        HouseholdLeaving
    }
}
