using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Devices
{
    public class NokiaTablet : Device
    {
        public NokiaTablet(string brand) : base(brand)
        {
        }

        public override int BatteryLife()
        {
            return 5100;
        }

        public override string Model()
        {
            return "Surface Pro";
        }

        public override int ScreenSize()
        {
            return 12;
        }

        public override int YearOfRelease()
        {
            return 2018;
        }
    }
}
