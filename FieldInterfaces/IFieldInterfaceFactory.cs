using System;
using System.Collections.Generic;
using System.Text;

namespace FieldInterfaces
{
    public interface IFieldInterfaceFactory
    {
        IFieldInterface Build(IRemoteEndPointConnectionInfo connectionInfo);
    }
}
