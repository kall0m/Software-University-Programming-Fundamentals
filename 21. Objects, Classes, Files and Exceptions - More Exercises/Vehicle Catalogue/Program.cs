using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Catalogue
{
    class Program
    {
        class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }
        }

        static void Main(string[] args)
        {
            var vehicles = ReadVehicles();

            var carsByModel = new Dictionary<string, Vehicle>();
            var trucksByModel = new Dictionary<string, Vehicle>();

            foreach (var vehicle in vehicles)
            {
                if(vehicle.Type.ToLower() == "car")
                {
                    carsByModel[vehicle.Model] = vehicle;
                }
                else if(vehicle.Type.ToLower() == "truck")
                {
                    trucksByModel[vehicle.Model] = vehicle;
                }
            }

            var models = ReadModels();

            PrintVehicles(carsByModel, trucksByModel, models);
            PrintAverageHorsePower(carsByModel, trucksByModel, models);
        }

        static void PrintAverageHorsePower(Dictionary<string, Vehicle> carsByModel, Dictionary<string, Vehicle> trucksByModel, List<string> models)
        {
            try
            {
                var averageCarsHorsepower = carsByModel.Values.Select(c => c.Horsepower).Average();
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:F2}.");
            }
            catch
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            try
            {
                var averageTrucksHorsepower = trucksByModel.Values.Select(t => t.Horsepower).Average();
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:F2}.");
            }
            catch
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }

        static void PrintVehicles(Dictionary<string, Vehicle> carsByModel, Dictionary<string, Vehicle> trucksByModel, List<string> models)
        {
            foreach (var model in models)
            {
                if (carsByModel.ContainsKey(model))
                {
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {carsByModel[model].Model}");
                    Console.WriteLine($"Color: {carsByModel[model].Color}");
                    Console.WriteLine($"Horsepower: {carsByModel[model].Horsepower}");
                }

                if (trucksByModel.ContainsKey(model))
                {
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {trucksByModel[model].Model}");
                    Console.WriteLine($"Color: {trucksByModel[model].Color}");
                    Console.WriteLine($"Horsepower: {trucksByModel[model].Horsepower}");
                }
            }
        }

        static List<string> ReadModels()
        {
            var models = new List<string>();

            var input = Console.ReadLine();

            while(input != "Close the Catalogue")
            {
                models.Add(input);

                input = Console.ReadLine();
            }

            return models;
        }

        static List<Vehicle> ReadVehicles()
        {
            var input = Console.ReadLine().Split();

            var vehicles = new List<Vehicle>();

            while (input[0] != "End")
            {
                var vehicleType = input[0].ToLower();
                var model = input[1];
                var color = input[2];
                var power = int.Parse(input[3]);

                vehicles.Add(new Vehicle
                {
                    Type = vehicleType,
                    Model = model,
                    Color = color,
                    Horsepower = power
                });

                input = Console.ReadLine().Split();
            }

            return vehicles;
        }
    }
}
