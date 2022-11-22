using System;

namespace VehiclesExtension
{
    public class Vehicle
    {
        protected double quantityOfFuel;
        protected double consumptionOfFuel;
        protected double capacityOfTank;

        public Vehicle(double quantityOfFuel, double consumptionOfFuel, double capacityOfTank)
        {
            this.consumptionOfFuel = consumptionOfFuel;
            this.capacityOfTank = capacityOfTank;

            if (quantityOfFuel <= capacityOfTank)
            {
                this.quantityOfFuel = quantityOfFuel;
            }
        }
        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }

            else if (this.quantityOfFuel + liters > this.capacityOfTank)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }

            else
            {
                this.quantityOfFuel += liters;
            }
        }

        public virtual void Drive(double kilometers)
        {
            double newFuelAmount = this.quantityOfFuel - this.consumptionOfFuel * kilometers;

            if (newFuelAmount < 0)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }

            else
            {
                this.quantityOfFuel = newFuelAmount;
                Console.WriteLine($"{this.GetType().Name} travelled {kilometers} km");
            }
        }

        public override string ToString() => $"{this.GetType().Name}: {this.quantityOfFuel:f2}";
    }
}