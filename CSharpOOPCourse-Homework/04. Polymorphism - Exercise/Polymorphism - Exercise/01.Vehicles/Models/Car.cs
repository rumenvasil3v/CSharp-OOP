using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double IncreasedFuelConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionPerKm, int tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity, IncreasedFuelConsumption)
        {
        }
    }
}
