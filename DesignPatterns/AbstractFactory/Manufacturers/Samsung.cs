using DesignPatterns.AbstractFactory.Devices;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Manufacturers
{
    public class Samsung : Manufacturer
    {
        public override string Brand()
        {
            return "Samsung";
        }

        public override Device GetSimplePhone()
        {
            return new SamsungSimplePhone(Brand());
        }

        public override Device GetSmartPhone()
        {
            return new SamsungSmartPhone(Brand());
        }

        public override Device GetTablet()
        {
            return new SamsungTablet(Brand());
        }
    }
}
