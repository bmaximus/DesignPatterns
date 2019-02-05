using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Devices
{
    public class SamsungSimplePhone : Device
    {
        public SamsungSimplePhone(string brand) : base(brand)
        {
        }

        public override int BatteryLife()
        {
            return 3100;
        }

        public override string Model()
        {
            return "YX 1000";
        }

        public override int ScreenSize()
        {
            return 3;
        }

        public override int YearOfRelease()
        {
            return 2017;
        }
    }
}
