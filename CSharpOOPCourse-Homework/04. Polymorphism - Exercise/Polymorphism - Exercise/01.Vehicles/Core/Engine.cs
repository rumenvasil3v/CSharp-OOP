/*
Car 30.4 0.4
Truck 99.34 0.9
5
Drive Car 500
Drive Car 13.5
Refuel Truck 10.300
Drive Truck 56.2
Refuel Car 100.2
 */

using System.Runtime.CompilerServices;
using Vehicles.Core.Interfaces;
using Vehicles.Factories.Interfaces;
using Vehicles.IO.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IVehicleFactory vehicleFactory;

        private readonly IDictionary<string, IVehicle> vehicles;

        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
            this.vehicles = new Dictionary<string, IVehicle>();
        }

        public void Run()
        {
            CreateVehicle(this.vehicles);
            CreateVehicle(this.vehicles);
            CreateVehicle(this.vehicles);

            int numberOfCommands = int.Parse(reader.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                try
                {
                    string[] command = reader.ReadLine().Split(" ");
                    ExecuteCommand(command, this.vehicles);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            writer.WriteLine(vehicles["Car"].ToString());
            writer.WriteLine(vehicles["Truck"].ToString());
            writer.WriteLine(vehicles["Bus"].ToString());
        }

        private void CreateVehicle(IDictionary<string, IVehicle> vehicles)
        {
            string vehicleInfo = Console.ReadLine();
            string[] vehicleArguments = vehicleInfo.Split(" ");
            double vehicleFuelQuantity = double.Parse(vehicleArguments[1]);
            double vehicleFuelConsumption = double.Parse(vehicleArguments[2]);
            int tankCapacity = int.Parse(vehicleArguments[3]);

            try
            {
                IVehicle vehicle = vehicleFactory.Create(vehicleArguments[0], vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);

                if (!vehicles.ContainsKey(vehicleArguments[0]))
                {
                    vehicles.Add(vehicleArguments[0], vehicle);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ExecuteCommand(string[] command, IDictionary<string, IVehicle> vehicles)
        {
            switch (command[0])
            {
                case "Drive":
                    vehicles[command[1]].DriveDistance(double.Parse(command[2]), command[0]);
                    break;
                case "Refuel":
                    vehicles[command[1]].RefuelVehicle(double.Parse(command[2]));
                    break;
                case "DriveEmpty":
                    vehicles[command[1]].DriveDistance(double.Parse(command[2]), command[0]);
                    break;
            }
        }
    }
}