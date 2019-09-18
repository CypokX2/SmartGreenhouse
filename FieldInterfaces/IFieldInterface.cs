using FieldInterfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FieldInterfaces
{
    public interface IFieldInterface
    {
        IRemoteEndPointConnectionInfo ConnectionInfo { get; }
        Boolean TryConnect();
        IResponse SendMessage(IMessage message);
    }
}
