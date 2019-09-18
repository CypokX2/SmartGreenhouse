using System;
using System.Collections.Generic;
using System.Text;
using GreenhouseDeviceManager.API;

namespace GreenhouseDeviceManager.Devices
{
    public interface IDeviceLogic
    {
        IEnumerable<IDevice> Devices { get; }

        IObservable<IOutputRequest> Requests { get; }

        ICommandResult ExecuteCommand(IInputCommand command);
    }
}
