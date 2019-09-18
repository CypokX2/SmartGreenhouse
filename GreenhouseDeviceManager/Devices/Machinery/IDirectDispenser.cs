using System;
using System.Collections.Generic;
using System.Text;

namespace GreenhouseDeviceManager.Devices.Machinery
{
    public interface IDirectDispenser : ILiquidDispenser
    {
        ILiquidPump Pump { get; }
        ILiquidDispenser Dispenser {get;}
        ILiquidDispenser DropdownDispenser { get; }
        TimeSpan DelayPump { get; }
        

    }
}
