using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Devices
{
    public class LgSimplePhone : Device
    {
        public LgSimplePhone(string brand) : base(brand)
        {
        }

        public override int BatteryLife()
        {
            return 3300;
        }

        public override string Model()
        {
            return "KF 6000";
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
