using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Devices
{
    public class LgSmartPhone : Device
    {
        public LgSmartPhone(string brand) : base(brand)
        {
        }

        public override int BatteryLife()
        {
            return 4100;
        }

        public override string Model()
        {
            return "LG V40";
        }

        public override int ScreenSize()
        {
            return 6;
        }

        public override int YearOfRelease()
        {
            return 2019;
        }
    }
}
