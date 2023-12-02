using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        double FuelQuantity { get; }

        double FuelConsumptionPerKm { get; }

        int TankCapacity { get; }

        void DriveDistance(double distance, string emptyOrNot);

        void RefuelVehicle(double amountOfFuel);
    }
}
