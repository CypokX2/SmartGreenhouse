using System;
using System.Collections.Generic;
using System.Text;

namespace GreenhouseDeviceManager.DeviceFactory
{
    public interface IDeviceSettingsRepository
    {
        IObservable<IDeviceSettings> GetSettingsObservable();
        Boolean TryAddSetting(IDeviceSettings deviceSettings);
        Boolean TryRemoveSetting(IDeviceSettings deviceSettings);
    }
}
