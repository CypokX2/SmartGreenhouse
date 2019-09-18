using FieldInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenhouseDeviceManager.DeviceFactory
{
    public interface IDeviceSettings
    {
        IRemoteEndPointConnectionInfo ConnectionInfo { get; }
    }
}
