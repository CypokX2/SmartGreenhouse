using System;
using System.Collections.Generic;
using System.Text;

namespace FieldInterfaces.Data
{
    public interface IResponse
    {
        IMessage ResponseMessage { get; }
    }
}
