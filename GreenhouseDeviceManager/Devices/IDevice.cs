using System;
using System.Collections.Generic;
using System.Text;

namespace GreenhouseDeviceManager.Devices
{
    public interface IDevice
    {
        IObservable<IDeviceConnectionState> State { get; }
    }
}
