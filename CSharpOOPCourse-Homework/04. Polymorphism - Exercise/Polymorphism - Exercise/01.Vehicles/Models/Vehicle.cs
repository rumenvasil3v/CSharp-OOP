using Vehicles.IO;
using Vehicles.IO.Interfaces;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private readonly IReader reader = new ConsoleReader();
        private readonly IWriter writer = new ConsoleWriter();

        private double increasedFuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, int tankCapacity, double increasedFuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.TankCapacity = tankCapacity;
            this.increasedFuelConsumption = increasedFuelConsumption;
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumptionPerKm { get; protected set; }

        public int TankCapacity { get; protected set; }

        //public void DriveDistance(double distance)
        //{
        //    double needFuel = (this.FuelConsumptionPerKm + this.increasedFuelConsumption) * distance;
        //    if (this.FuelQuantity - needFuel >= 0)
        //    {
        //        writer.WriteLine($"{this.GetType().Name} travelled {distance} km");
        //        this.FuelQuantity -= needFuel;
        //    }
        //    else
        //    {
        //        throw new ArgumentException($"{this.GetType().Name} needs refueling");
        //    }
        //}

        public void DriveDistance(double distance, string emptyOrNot)
        {
            if (emptyOrNot == "DriveEmpty")
            {
                this.increasedFuelConsumption = 0;
            }

            double needFuel = (this.FuelConsumptionPerKm + this.increasedFuelConsumption) * distance;
            if (this.FuelQuantity - needFuel >= 0)
            {
                writer.WriteLine($"{this.GetType().Name} travelled {distance} km");
                this.FuelQuantity -= needFuel;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
        }

        public void RefuelVehicle(double amountOfFuel)
        {
            if (amountOfFuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            double templateForAmountOfFuel = amountOfFuel;

            if (this.GetType().Name == "Truck")
            {
                amountOfFuel = amountOfFuel * 0.95;
            }

            if (amountOfFuel + this.FuelQuantity <= this.TankCapacity)
            {
                this.FuelQuantity += amountOfFuel;
            }
            else
            {
                throw new ArgumentException($"Cannot fit {templateForAmountOfFuel} fuel in the tank");
            }
        }

        public override string ToString() => $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}