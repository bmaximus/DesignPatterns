using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Devices
{
    public class SamsungTablet : Device
    {
        public SamsungTablet(string brand) : base(brand)
        {
        }

        public override int BatteryLife()
        {
            return 7000;
        }

        public override string Model()
        {
            return "Galaxy Tab";
        }

        public override int ScreenSize()
        {
            return 13;
        }

        public override int YearOfRelease()
        {
            return 2018;
        }
    }
}
