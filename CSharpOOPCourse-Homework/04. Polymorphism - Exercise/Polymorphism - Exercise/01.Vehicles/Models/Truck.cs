namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double IncreasedFuelConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, int tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity, IncreasedFuelConsumption)
        {
        }
    }
}