using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Devices
{
    public class SamsungSmartPhone : Device
    {
        public SamsungSmartPhone(string brand) : base(brand)
        {
        }

        public override int BatteryLife()
        {
            return 4600;
        }

        public override string Model()
        {
            return "Note 9";
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
