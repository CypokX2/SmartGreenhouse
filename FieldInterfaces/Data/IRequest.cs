using System;
using System.Collections.Generic;
using System.Text;

namespace FieldInterfaces.Data
{
    public interface IRequest
    {
        IMessage RequestMessage { get; }
    }
}
