using DesignPatterns.Factory;
using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Design Patterns Tester");
            PrintSpase();
            
            var singletonCollector = new List<SingletonPattern>
            {
                SingletonPattern.GetSingleton(),
                SingletonPattern.GetSingleton()
            };
            for (int i = 0; i < singletonCollector.Count; i++)
            {
                Console.WriteLine($"Singleton {i} " + singletonCollector[i].GetInstance());
            }
            PrintSpase();

            var vehicleCollector = new List<Vehicle>()
            {
               VehicleFactory.GetVehicleByPrice(4000),
               VehicleFactory.GetVehicleByPrice(40000),
               VehicleFactory.GetVehicleByPrice(4000000)
            };

            for (int i = 0; i < vehicleCollector.Count; i++)
            {
                Console.WriteLine($"Factory {i} created type of {vehicleCollector[i].GetType()} {vehicleCollector[i].VehicleName()}  Costs: {vehicleCollector[i].VehiclePrice()} ");
            }
            PrintSpase();


            PrintSpase();
            Console.WriteLine("Closing Design Patters Tester");
            Thread.Sleep(10000);
        }

        private static void PrintSpase()
        {
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
