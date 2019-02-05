using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Devices
{
    public class NokiaSmartPhone : Device
    {
        public NokiaSmartPhone(string brand) : base(brand)
        {
        }

        public override int BatteryLife()
        {
            return 3200;
        }

        public override string Model()
        {
            return "Lumia";
        }

        public override int ScreenSize()
        {
            return 4;
        }

        public override int YearOfRelease()
        {
            return 2009;
        }
    }
}
