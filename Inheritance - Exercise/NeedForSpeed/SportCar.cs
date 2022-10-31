namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DEFAULT_SPORTCAR_FUEL_CONSUMPTION = 10;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel) {}
        public override double FuelConsumption => DEFAULT_SPORTCAR_FUEL_CONSUMPTION;
    }
}
