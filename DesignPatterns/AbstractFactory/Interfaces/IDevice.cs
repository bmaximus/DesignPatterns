using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface IDevice
    {
        string Model();
        int ScreenSize();
        int BatteryLife();
        int YearOfRelease();
    }
}
