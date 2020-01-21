using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQASkeletronPlus.Events;

namespace AQASkeletronPlus
{
    /// <summary>
    /// Represents a single company within the AQA Skeleton simulation.
    /// </summary>
    public class Company
    {
        //Accessible locals for the company.
        public double FuelCost { get; private set; }
        public double Balance { get; private set; }
        public double BaseDeliveryCost { get; private set; }
        public string Name { get; private set; }
        public CompanyType Type { get; private set; }
        public double Reputation { get; private set; } = Settings.Get.StartingReputation;
        public double DailyCost { get; private set; } = Settings.Get.StartingDailyCost;
        public int OutletCapacity { get; private set; }
        public double OutletCost { get; private set; }

        //Inaccessible locals for the company.
        public List<Outlet> outlets { get; protected set; } = new List<Outlet>();
        private double avgCostPerMeal, avgPricePerMeal;

        //The settlement this was created on.
        private Settlement settlement;

        /// <summary>
        /// Opens a company, and sets all the required local parameters.
        /// </summary>
        public Company(Settlement s, string name, CompanyType type, double balance, Vector2 hqPosition, double fuelCostPerTile, double baseDeliveryCost)
        {
            //Set locals.
            Name = name;
            Type = type;
            Balance = balance;
            FuelCost = fuelCostPerTile;
            BaseDeliveryCost = baseDeliveryCost;
            settlement = s;

            //Update meal cost and reputation based on type of establishment.
            SetCompanyBasics(type);

            //Open the company headquarters.
            OpenOutlet(hqPosition);
        }

        /// <summary>
        /// Opens an outlet at a given position on a settlement (or a random one).
        /// </summary>
        public void OpenOutlet(Vector2 position=null)
        {
            //Need to generate a random position?
            if (position == null)
            {
                position = settlement.GetFreeRandomPosition();
            }
            else
            {
                //Check if the position is occupied.
                if (settlement.IsOccupied(position)) { throw new Exception("Cannot open an outlet there, the space is occupied."); }
            }

            //Sufficient balance?
            if (Balance < OutletCost) { throw new Exception("Cannot open an outlet, insufficient company balance."); }

            //Open the outlet.
            Balance -= OutletCost;
            outlets.Add(new Outlet(settlement, this, position, OutletCapacity, DailyCost));

            //Log in the event chain.
            EventChain.AddEvent(new OutletCreateEvent()
            {
                Position = position,
                Capacity = OutletCapacity
            });
        }

        /// <summary>
        /// Expands this outlet from it's current capacity.
        /// </summary>
        public void ExpandOutlet(Outlet outlet, int amtSeats)
        {
            OutletCapacity += amtSeats;
            DailyCost += amtSeats * 0.5;
        }

        /// <summary>
        /// Closes every open outlet for this company.
        /// </summary>
        public void CloseAllOutlets()
        {
            while (outlets.Count > 0) { CloseOutlet(outlets[0]); }
        }

        /// <summary>
        /// Closes a single outlet that this company owns.
        /// </summary>
        public void CloseOutlet(Outlet outlet)
        {
            //Incur a cost per seat, depending on the type.
            int cps = -1;
            switch (Type)
            {
                case CompanyType.FastFood: cps = Settings.Get.FastFoodClosingCostPerSeat; break;
                case CompanyType.Family: cps = Settings.Get.FamilyClosingCostPerSeat; break;
                case CompanyType.NamedChef: cps = Settings.Get.NamedChefClosingCostPerSeat; break;
                default: throw new Exception("Invalid company type to close.");
            }

            //Incur the cost.
            Balance -= cps * outlet.Capacity;

            //Now, close the actual outlet.
            outlets.Remove(outlet);
        }

        /// <summary>
        /// Adds a single household visit to the outlet nearest to the given Vector2 position.
        /// </summary>
        public void AddVisitToNearestOutlet(Vector2 position, ref List<Tuple<Vector2, Vector2>> visits)
        {
            //Any outlets to visit?
            if (outlets.Count == 0) { return; }

            //Loop over outlets and get distances.
            Outlet nearest = null;
            double nearestDistance = double.MaxValue;
            foreach (var outlet in outlets)
            {
                //Found a better distance?
                double thisDist = position.DistanceTo(outlet.Position);
                if (thisDist < nearestDistance)
                {
                    nearest = outlet;
                    nearestDistance = thisDist;
                }
            }

            //Was an outlet found? If so, add it, and log the visit to the list.
            if (nearest == null) { return; }
            nearest.Visit(position);
            visits.Add(new Tuple<Vector2, Vector2>(position, nearest.Position));
        }

        /// <summary>
        /// Processes the end of the day for this company.
        /// </summary>
        public void ProcessDayEnd()
        {
            //Set up locals.
            double deliveryCosts = 0, profitLossFromOutlets = 0;

            //Move all the food trucks first.
            foreach (var outlet in outlets)
            {
                if (outlet is FoodTruck)
                {
                    //Move it.
                    ((FoodTruck)outlet).Move();
                }
            }

            //Calculate delivery costs.
            deliveryCosts += BaseDeliveryCost + CalculateDeliveryCost();
            Balance -= deliveryCosts;
            EventChain.AddEvent(new DeliveryEvent()
            {
                CompanyName = Name,
                Cost = deliveryCosts,
                Type = EventType.Delivery
            });

            //Calculate outlet profit and loss.
            foreach (var outlet in outlets)
            {
                double thisOutletProfit = outlet.GetDailyProfit(avgCostPerMeal, avgPricePerMeal);
                profitLossFromOutlets += thisOutletProfit;

                //Log an outlet's profits/losses.
                EventChain.AddEvent(new OutletProfitEvent()
                {
                    ProfitLoss = thisOutletProfit,
                    Company = Name
                });

                outlet.ProcessDayEnd();
            }

            //Update balance.
            Balance += profitLossFromOutlets;

            //Close the company?
            if (Balance <= 0)
            {
                CloseAllOutlets();
            }
        }

        /// <summary>
        /// Changes the average meal cost for all outlets by a given amount.
        /// </summary>
        /// <param name="amt"></param>
        public void ChangeAvgMealCostBy(double amt)
        {
            avgCostPerMeal += amt;
            if (avgCostPerMeal < 0) { avgCostPerMeal = 0; }
        }

        /// <summary>
        /// Changes the daily cost for the company by a given double amount.
        /// </summary>
        public void ChangeDailyCostBy(double amt)
        {
            DailyCost += amt;
            if (DailyCost < 0) { DailyCost = 0; }
        }

        /// <summary>
        /// Changes the reputation for the company by a given double amount, negative or positive.
        /// </summary>
        public void ChangeReputationBy(double amt)
        {
            Reputation += amt;
            if (Reputation < 0) { Reputation = 0; }
        }

        /// <summary>
        /// Changes the fuel cost for the company by a given double amount, negative or positive.
        /// </summary>
        public void ChangeFuelCostBy(double amt, double hardCap = double.MaxValue)
        {
            FuelCost += amt;
            if (FuelCost < 0) { FuelCost = 0; }
            if (FuelCost > hardCap) { FuelCost = hardCap; }
        }

        //Calculates the on top delivery costs for the day.
        private double CalculateDeliveryCost()
        {
            //1 outlet? No extra cost.
            if (outlets.Count <= 1) { return 0; }

            double totalDist = 0;
            for (int i = 0; i < outlets.Count - 1; i++)
            {
                //Get the total distance.
                totalDist += GetDistanceBetweenOutlets(outlets[i], outlets[i + 1]);
            }

            //Multiply distance by fuel cost.
            return totalDist * FuelCost;
        }
        
        //Uses AQA patented dark magic technology to calculate distances between outlets.
        private double GetDistanceBetweenOutlets(Outlet outlet1, Outlet outlet2)
        {
            return Math.Sqrt((Math.Pow(outlet1.Position.x - outlet2.Position.x, 2)) + (Math.Pow(outlet1.Position.y - outlet1.Position.y, 2)));
        }

        //Sets meal costs for this company based on the type of establishment.
        private void SetCompanyBasics(CompanyType type)
        {
            switch (type)
            {
                //Sets all parameterized settings for the company.
                case CompanyType.Family:
                    avgCostPerMeal = Settings.Get.FamilyCostPerMeal;
                    avgPricePerMeal = Settings.Get.FamilyPricePerMeal;
                    Reputation += Simulation.Random.Next(0, Settings.Get.FamilyRandomMaxRep) - 8;
                    OutletCapacity = Settings.Get.FamilyOutletCapacity;
                    OutletCost = Settings.Get.FamilyOutletCost;
                    break;
                case CompanyType.FastFood:
                    avgCostPerMeal = Settings.Get.FastFoodCostPerMeal;
                    avgPricePerMeal = Settings.Get.FastFoodPricePerMeal;
                    Reputation += Simulation.Random.Next(0, Settings.Get.FastFoodRandomMaxRep) - 8;
                    OutletCapacity = Settings.Get.FastFoodOutletCapacity;
                    OutletCost = Settings.Get.FastFoodOutletCost;
                    break;
                case CompanyType.NamedChef:
                    avgCostPerMeal = Settings.Get.NamedChefCostPerMeal;
                    avgPricePerMeal = Settings.Get.NamedChefPricePerMeal;
                    Reputation += Simulation.Random.Next(0, Settings.Get.NamedChefRandomMaxRep) - 8;
                    OutletCapacity = Settings.Get.NamedChefOutletCapacity;
                    OutletCost = Settings.Get.NamedChefOutletCost;
                    break;
                default:
                    throw new Exception("Unrecognized company type to set basic parameters for.");
            }
        }
    }

    public enum CompanyType
    {
        FastFood,
        NamedChef,
        Family,
    }
}
