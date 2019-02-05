using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Devices;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Threading;
using Type = DesignPatterns.AbstractFactory.Type;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Design Patterns Tester");
            PrintSpase();

            #region Singleton
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
            #endregion

            #region Factory
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
            #endregion

            #region Abstract Factory
            var mobiles = new List<Device>()
            {
              AbstractFactory.AbstractFactory.GetMobileDevice(Model.Samsung, Type.Smart),
              AbstractFactory.AbstractFactory.GetMobileDevice(Model.Lg, Type.Tablet),
              AbstractFactory.AbstractFactory.GetMobileDevice(Model.Nokia, Type.Simple)
            };
            for (int i = 0; i < mobiles.Count; i++)
            {
                Console.WriteLine($"Abstact Factory: {i} Brand {mobiles[i].Brand()} Model: {mobiles[i].Model()} Screen: {mobiles[i].ScreenSize()} Battery: {mobiles[i].BatteryLife()} YoR: {mobiles[i].YearOfRelease()}");
            }


            #endregion

            #region Prototype

            #endregion

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
