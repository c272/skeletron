# Custom Settings
The AQA SKPE supports granular settings, however they aren't set in the simulation along with the other basic settings.
To create custom settings, you should create a file named `settings.ini` in the same folder as the emulator executable.

In this file, you can use standard `.ini` keypairs, such as the following, to configure settings:
```
ExampleKey=VALUE ; This is a comment.
```

Below is a list of different settings you can change, their type, and what they do.

## Settings List

### DefaultSimulationWidth

(*Default: 500*, Type: Integer) The default simulation width when starting the program.

---
### DefaultSimulationHeight

(*Default: 500*, Type: Integer) The default simulation height when starting the program.

---
### DefaultSimulationHouses

(*Default: 250*, Type: Integer) The default amount of houses to set when starting the program.

---
### BaseChanceOfRandomEvents
(*Default: 0.25, Type: Float*) The base chance that any random events will occur at the end of the day.

---
### ChanceOfAddHouseholdsEvent

(*Default: 0.25, Type: Float*) The chance that new houses will be added to the settlement at the end of the day.

---
### ChanceOfChangeFuelCostEvent

(*Default: 0.5, Type: Float*) The chance that the fuel cost for 1 company will be changed at the end of the day.

---
### ChanceOfReputationChangeEvent

(*Default: 0.5, Type: Float*) The chance that the reputation for 1 company will be changed at the end of the day.

---
### ChanceOfCostChangeEvent

(*Default: 0.5, Type: Float*) The chance that a single cost type for 1 company will be changed at the end of the day.

---
### MinNewHouseholds

(*Default: 1, Type: Integer*) The lowest number of houses that will be added in a random add households event.

---
### MaxNewHouseholds

(*Default: 5, Type: Integer*) The maximum number of houses that will be added in a random add households event.

---
### ChanceOfFuelPriceIncrease

(*Default: 0.5, Type: Float*) Chance that the fuel price will go up during a random fuel cost change event.

---
### ChanceOfReputationIncrease

(*Default: 0.5, Type: Float*) Chance that the reputation will go up during a random reputation change event.

---
### ChanceOfCostIncrease

(*Default: 0.5, Type: Float*) Chance that a random chosen cost will go up during a random cost change event.

---
### ChanceOfFuelPriceIncrease

(*Default: 0.5, Type: Float*) Chance that the fuel price will go up during a random fuel cost change event.

---
### DefaultSettlementWidth

(*Default: 1000, Type: Integer*) The default width of the base settlement class. Overridden by **DefaultSimulationWidth**.

---
### DefaultSettlementHeight

(*Default: 1000, Type: Integer*) The default height of the base settlement class. Overridden by **DefaultSimulationHeight**.

---
### DefaultSettlementStartingHouses

(*Default: 250, Type: Integer*) The default amount of houses for the base settlement class. Overridden by **DefaultSimulationHouses**.

---
### ChanceOfHouseholdLeaving

(*Default: 0.0005, Type: Float*) The chance of a household leaving at the end of the day.

---
### StartingReputation

(*Default: 100, Type: Integer*) The amount of starting reputation for each company.

---
### StartingDailyCost

(*Default: 100, Type: Integer*) The starting daily costs for each company.

---
### FuelCostPerTile

(*Default: 0.0098, Type: Float*) The initial fuel cost per tile moved for each company.

---
### BaseCostForDelivery

(*Default: 100.0, Type: Float*) Initial base delivery cost (without fuel) for each company.

---
### FamilyOutletCost

(*Default: 1000, Type: Integer*) The cost of opening a new outlet for a family company.

---
### FamilyOutletCapacity

(*Default: 150, Type: Integer*) The default capacity of a new outlet for a family company.

---
### FamilyCostPerMeal

(*Default: 12, Type: Integer*) The cost of creating a meal for a family company.

---
### FamilyPricePerMeal

(*Default: 14, Type: Integer*) The cost that family companies charge per meal.

---
### FamilyRandomMaxRep

(*Default: 10, Type: Integer*) The maximum random reputation gained by a family company each day.

---
### FamilyClosingCostPerSeat

(*Default: 50, Type: Integer*) The cost of a single seat incurred when closing a family company outlet.

---
### FastFoodOutletCost

(*Default: 2000, Type: Integer*) The cost of opening a new outlet for a fast food company.

---
### FastFoodOutletCapacity

(*Default: 200, Type: Integer*) The default capacity of a new outlet for a fast food company.

---
### FastFoodCostPerMeal

(*Default: 5, Type: Integer*) The cost of creating a meal for a fast food company.

---
### FastFoodPricePerMeal

(*Default: 10, Type: Integer*) The cost that fast food companies charge per meal.

---
### FastFoodRandomMaxRep

(*Default: 30, Type: Integer*) The maximum random reputation gained by a fast food company each day.

---
### FastFoodClosingCostPerSeat

(*Default: 75, Type: Integer*) The cost of a single seat incurred when closing a fast food company outlet.

---
### NamedChefOutletCost

(*Default: 15000, Type: Integer*) The cost of opening a new outlet for a named chef company.

---
### NamedChefOutletCapacity

(*Default: 50, Type: Integer*) The default capacity of a new outlet for a named chef company.

---
### NamedChefCostPerMeal

(*Default: 20, Type: Integer*) The cost of creating a meal for a named chef company.

---
### NamedChefPricePerMeal

(*Default: 40, Type: Integer*) The cost that named chef companies charge per meal.

---
### NamedChefRandomMaxRep

(*Default: 50, Type: Integer*) The maximum random reputation gained by a named chef company each day.

---
### NamedChefClosingCostPerSeat

(*Default: 150, Type: Integer*) The cost of a single seat incurred when closing a named chef company outlet.

---