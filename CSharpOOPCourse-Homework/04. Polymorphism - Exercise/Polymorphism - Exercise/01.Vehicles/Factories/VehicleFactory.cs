using Vehicles.Factories.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle Create(string type, double fuelQuantity, double fuelConsumptionPerKm, int tankCapacity)
        {
            switch (type)
            {
                case "Car":
                    fuelQuantity = CheckIfFuelQuantityIsMoreThanTankCapacity(fuelQuantity, tankCapacity);
                    return new Car(fuelQuantity, fuelConsumptionPerKm, tankCapacity);
                case "Truck":
                    fuelQuantity = CheckIfFuelQuantityIsMoreThanTankCapacity(fuelQuantity, tankCapacity);
                    return new Truck(fuelQuantity, fuelConsumptionPerKm, tankCapacity);
                case "Bus":
                    fuelQuantity = CheckIfFuelQuantityIsMoreThanTankCapacity(fuelQuantity, tankCapacity);
                    return new Bus(fuelQuantity, fuelConsumptionPerKm, tankCapacity);
                default:
                    throw new ArgumentException($"{type} is invalid!");
            }
        }

        private double CheckIfFuelQuantityIsMoreThanTankCapacity(double fuelQuantity, int tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0;
            }

            return fuelQuantity;
        }
    }
}