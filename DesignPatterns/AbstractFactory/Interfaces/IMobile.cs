using DesignPatterns.AbstractFactory.Devices;

namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface IMobile
    {
        string Brand();
        Device GetSimplePhone();
        Device GetSmartPhone();
        Device GetTablet();
    }
}
