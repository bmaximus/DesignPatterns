using DesignPatterns.AbstractFactory.Devices;
using DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Manufacturers
{
    public abstract class Manufacturer : IMobile
    {
        public Device GetByType(Type type)
        {
            switch (type)
            {
                case Type.Simple:
                    return GetSimplePhone();
                case Type.Smart:
                    return GetSmartPhone();
                case Type.Tablet:
                    return GetTablet();
                default:
                    return GetSimplePhone();
            }
        }
        public abstract string Brand();

        public abstract Device GetSimplePhone();

        public abstract Device GetSmartPhone();

        public abstract Device GetTablet();
    }
}
