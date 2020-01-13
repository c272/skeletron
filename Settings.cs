using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Config.Net;

namespace AQASkeletronPlus
{
    /// <summary>
    /// Dummy class for accessing settings globally.
    /// </summary>
    public class Settings
    {
        //Settings.
        public static ISettings Get;
    }

    /// <summary>
    /// Represents the settings file for this skeleton program simulator.
    /// </summary>
    public interface ISettings
    {
        //General settlement options.
        [Option(DefaultValue = 1000)]
        int DefaultSettlementWidth { get; }

        [Option(DefaultValue = 1000)]
        int DefaultSettlementHeight { get; }

        [Option(DefaultValue = 250)]
        int DefaultSettlementStartingHouses { get; }


        //General company options
        [Option(DefaultValue = 100)]
        int StartingReputation { get; }

        [Option(DefaultValue = 100)]
        int StartingDailyCost { get; }


        //Options for family companies.
        [Option(DefaultValue = 1000)]
        int FamilyOutletCost { get; }

        [Option(DefaultValue = 150)]
        int FamilyOutletCapacity { get; }

        [Option(DefaultValue = 12)]
        int FamilyCostPerMeal { get; }

        [Option(DefaultValue = 14)]
        int FamilyPricePerMeal { get; }

        [Option(DefaultValue = 10)]
        int FamilyRandomMaxRep { get; }

        [Option(DefaultValue = 50)]
        int FamilyClosingCostPerSeat { get; }


        //Options for fast food companies.
        [Option(DefaultValue = 2000)]
        int FastFoodOutletCost { get; }

        [Option(DefaultValue = 200)]
        int FastFoodOutletCapacity { get; }

        [Option(DefaultValue = 5)]
        int FastFoodCostPerMeal { get; }

        [Option(DefaultValue = 10)]
        int FastFoodPricePerMeal { get; }

        [Option(DefaultValue = 30)]
        int FastFoodRandomMaxRep { get; }

        [Option(DefaultValue = 75)]
        int FastFoodClosingCostPerSeat { get; }


        //Options for named chef companies.
        [Option(DefaultValue = 15000)]
        int NamedChefOutletCost { get; }

        [Option(DefaultValue = 50)]
        int NamedChefOutletCapacity { get; }

        [Option(DefaultValue = 20)]
        int NamedChefCostPerMeal { get; }

        [Option(DefaultValue = 40)]
        int NamedChefPricePerMeal { get; }

        [Option(DefaultValue = 50)]
        int NamedChefRandomMaxRep { get; }

        [Option(DefaultValue = 150)]
        int NamedChefClosingCostPerSeat { get; }
    }
}
