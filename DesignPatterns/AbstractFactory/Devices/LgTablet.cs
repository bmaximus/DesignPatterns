using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Devices
{
    public class LgTablet : Device
    {
        public LgTablet(string brand) : base(brand)
        {
        }

        public override int BatteryLife()
        {
            return 6500;
        }

        public override string Model()
        {
            return "Tab 12";
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
