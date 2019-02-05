using DesignPatterns.AbstractFactory.Devices;
using DesignPatterns.AbstractFactory.Interfaces;
using DesignPatterns.AbstractFactory.Manufacturers;

namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactory
    {
        public static Device GetMobileDevice(Model model, Type type)
        {
            switch (model)
            {
                case Model.Samsung:
                    return new Samsung().GetByType(type);
                case Model.Nokia:
                    return new Nokia().GetByType(type);
                case Model.Lg:
                    return new Lg().GetByType(type);
                default:
                    return new Nokia().GetByType(type);
            }
        }
    }

    public enum Type
    {
        Simple = 1,
        Smart = 2,
        Tablet = 3
    }

    public enum Model
    {
        Samsung = 1,
        Nokia = 2,
        Lg = 3
    }

}
