using System;
using System.Collections.Generic;
using System.Text;
using GreenhouseDeviceManager.Devices;

namespace GreenhouseDeviceManager.DeviceFactory
{
    public interface IDeviceFactory
    {
        IDevice Build(IDeviceSettings settings);
    }
}
