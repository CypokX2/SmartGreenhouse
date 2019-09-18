using GreenhouseDeviceManager.DeviceFactory;
using System;
using System.Collections.Generic;
using System.Text;
using GreenhouseDeviceManager.Devices;

namespace GreenhouseDeviceManager
{
    public interface IDeviceProvider
    {
        IObservable<IEnumerable<IDevice>> ConnectedDevices { get; }
        IObservable<IDevice> GetPlainDevicesObservable();
        IDeviceFactory Factory { get; }
        IDeviceSettingsRepository SettingsRepository { get; }

    }
}
