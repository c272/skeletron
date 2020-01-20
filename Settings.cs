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

        //AQA provided default companies.
        internal static List<CompanyDefault> DefaultCompanies = new List<CompanyDefault>()
        {
            //AQA Burgers
            new CompanyDefault()
            {
                Name = "AQA Burgers",
                StartingBalance = 100000,
                Type = CompanyType.FastFood,
                StartingOutlets = 6
            },

            //Ben Thor Cuisine
            new CompanyDefault()
            {
                Name = "Ben Thor Cuisine",
                StartingBalance = 100400,
                Type = CompanyType.NamedChef,
                StartingOutlets = 0
            },

            //Paltry Poultry
            new CompanyDefault()
            {
                Name = "Paltry Poultry",
                StartingBalance = 25000,
                Type = CompanyType.FastFood,
                StartingOutlets = 3
            }
        };
    }

    /// <summary>
    /// Represents the settings file for this skeleton program simulator.
    /// </summary>
    public interface ISettings
    {
        //Simulation defaults.
        [Option(DefaultValue = 500)]
        int DefaultSimulationWidth { get; }

        [Option(DefaultValue = 500)]
        int DefaultSimulationHeight { get; }

        [Option(DefaultValue = 250)]
        int DefaultSimulationHouses { get; }


        //Simulation randomizer options.
        [Option(DefaultValue = 0.25)]
        double BaseChanceOfRandomEvents { get; }

        [Option(DefaultValue = 0.25)]
        double ChanceOfAddHouseholdsEvent { get; }

        [Option(DefaultValue = 0.5)]
        double ChanceOfChangeFuelCostEvent { get; }

        [Option(DefaultValue = 0.5)]
        double ChanceOfReputationChangeEvent { get; }

        [Option(DefaultValue = 0.5)]
        double ChanceOfCostChangeEvent { get; }

        //Household randomizer options.
        [Option(DefaultValue = 1)]
        int MinNewHouseholds { get; }

        [Option(DefaultValue = 5)]
        int MaxNewHouseholds { get; }

        [Option(DefaultValue = 20)]
        int MaxNewSeats { get; }

        //Fuel randomizer options.
        [Option(DefaultValue = 0.5)]
        double ChanceOfFuelPriceIncrease { get; }

        //Reputation randomizer options.
        [Option(DefaultValue = 0.5)]
        double ChanceOfReputationIncrease { get; }

        //Cost change randomizer options.
        [Option(DefaultValue = 0.5)]
        double ChanceOfCostIncrease { get; }


        //General settlement options.
        [Option(DefaultValue = 1000)]
        int DefaultSettlementWidth { get; }

        [Option(DefaultValue = 1000)]
        int DefaultSettlementHeight { get; }

        [Option(DefaultValue = 250)]
        int DefaultSettlementStartingHouses { get; }
        
        [Option(DefaultValue = 0.0005)]
        double ChanceOfHouseholdLeaving { get; }


        //General company options
        [Option(DefaultValue = 100)]
        int StartingReputation { get; }

        [Option(DefaultValue = 100)]
        int StartingDailyCost { get; }
        
        [Option(DefaultValue = 0.0098)]
        double FuelCostPerTile { get; }

        [Option(DefaultValue = 100.0)]
        double BaseCostForDelivery { get;}


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
