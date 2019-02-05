using DesignPatterns.AbstractFactory.Devices;

namespace DesignPatterns.AbstractFactory.Manufacturers
{
    public class Lg : Manufacturer
    {
        public override string Brand()
        {
            return "LG";
        }

        public override Device GetSimplePhone()
        {
            return new LgSimplePhone(Brand());
        }

        public override Device GetSmartPhone()
        {
            return new LgSmartPhone(Brand());
        }

        public override Device GetTablet()
        {
            return new LgTablet(Brand());
        }
    }
}
