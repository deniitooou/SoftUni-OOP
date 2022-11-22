using System;

namespace Vehicles
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInformation = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carInformation[1]), double.Parse(carInformation[2]));

            string[] truckInformation = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(truckInformation[1]), double.Parse(truckInformation[2]));

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                string type = tokens[1];
                double value = double.Parse(tokens[2]);

                if (command == "Drive")
                {
                    if (type == "Car")
                    {
                        car.Drive(value);
                    }
                    else if (type == "Truck")
                    {
                        truck.Drive(value);
                    }
                }

                else if (command == "Refuel")
                {
                    if (type == "Car")
                    {
                        car.Refuel(value);
                    }

                    else if (type == "Truck")
                    {
                        truck.Refuel(value);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}