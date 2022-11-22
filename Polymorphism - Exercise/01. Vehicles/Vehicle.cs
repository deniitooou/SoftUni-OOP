using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Vehicle
    {
        private double quantityOfFuel;
        private double consumptionOfFuel;

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.quantityOfFuel = fuelQuantity;
            this.consumptionOfFuel = fuelConsumption;
        }

        public virtual void Refuel(double liters)
        {
            this.quantityOfFuel += liters;
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