using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenhouseDeviceManager
{
    public interface IDevicePublisher
    {
        IDeviceProvider Provider { get; }

        Task StartAsync(CancellationToken cancellation);
    }
}
