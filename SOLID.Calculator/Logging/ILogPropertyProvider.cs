using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Math.Logging
{
    public interface ILogPropertyProvider
    {
        void ApplyProperties(IDictionary<string, object> templateContext);
    }
}
