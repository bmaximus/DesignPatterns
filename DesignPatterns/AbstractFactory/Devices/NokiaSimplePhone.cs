using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Devices
{
    public class NokiaSimplePhone : Device
    {
        public NokiaSimplePhone(string brand) : base(brand)
        {
        }

        public override int BatteryLife()
        {
            return 3500;
        }

        public override string Model()
        {
            return "3310";
        }

        public override int ScreenSize()
        {
            return 1;
        }

        public override int YearOfRelease()
        {
            return 2001;
        }
    }
}
