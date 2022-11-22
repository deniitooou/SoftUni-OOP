using System;

namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double REFUEL_MODIFIER = 0.95;
        private const double CONSUMPTION_INCREASE = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + CONSUMPTION_INCREASE, tankCapacity) { }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }

            else if (this.quantityOfFuel + liters * REFUEL_MODIFIER > this.capacityOfTank)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }

            else
            {
                base.Refuel(liters * REFUEL_MODIFIER);
            }
        }
    }
}