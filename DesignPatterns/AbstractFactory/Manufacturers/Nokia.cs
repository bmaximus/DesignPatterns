using DesignPatterns.AbstractFactory.Devices;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Manufacturers
{
    public class Nokia : Manufacturer
    {
        public override string Brand()
        {
            return "Nokia";
        }

        public override Device GetSimplePhone()
        {
            return new NokiaSimplePhone(Brand());
        }

        public override Device GetSmartPhone()
        {
            return new NokiaSmartPhone(Brand());
        }
                
        public override Device GetTablet()
        {
            return new NokiaTablet(Brand());
        }
    }
}
