namespace _44.VehicleCatalogue
{
    internal class Program
    {
        public class Truck
        {
            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }

            public string Brand { get; set; }

            public string Model { get; set; }

            public int Weight { get; set; }
        }

        public class Car
        {
            public Car(string brand, string model, int hp)
            {
                Brand = brand;
                Model = model;
                HorsePower = hp;
            }

            public string Brand { get; set; }

            public string Model { get; set; }

            public int HorsePower { get; set; }
        }

        public class Catalogue
        {
            public Catalogue()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }

            public List<Car> Cars { get; set; }

            public List<Truck> Trucks { get; set; }

        }

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Catalogue catalogue = new Catalogue();

            while (command != "end")
            {
                string[] inputData = command.Split("/").ToArray();

                string currentVehicleType = inputData[0];
                string currentVehicleBrand = inputData[1];
                string currentVehicleModel = inputData[2];
                

                if (currentVehicleType == "Car")
                {
                    int currentVehicleHorsePower = int.Parse(inputData[3]);
                    Car currentCar = new Car(currentVehicleBrand, currentVehicleModel, currentVehicleHorsePower);
                    catalogue.Cars.Add(currentCar);
                }
                else
                {
                    int currentVehicleWeight = int.Parse(inputData[3]);
                    Truck currentTruck = new Truck(currentVehicleBrand, currentVehicleModel, currentVehicleWeight);
                    catalogue.Trucks.Add(currentTruck);
                }

                command = Console.ReadLine();
            }

            if (catalogue.Cars.Count > 0)
            {
                List<Car> orderedCars = catalogue.Cars.OrderBy(car => car.Brand).ToList();

                Console.WriteLine("Cars:");
                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            };

            if (catalogue.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalogue.Trucks.OrderBy(truck => truck.Brand).ToList();

                Console.WriteLine("Trucks:");
                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            };

        }
    }
}