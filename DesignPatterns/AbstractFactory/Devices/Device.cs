using DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Devices
{
    public abstract class Device : IDevice
    {
        private string _brand;

        public Device(string brand)
        {
            _brand = brand;
        }

        public string Brand() { return _brand; }
        public abstract int BatteryLife();
        public abstract string Model();
        public abstract int ScreenSize();
        public abstract int YearOfRelease();
    }
}
