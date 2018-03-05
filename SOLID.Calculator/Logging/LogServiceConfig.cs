using System.Collections.Generic;

namespace SOLID.Math.Logging
{
    public class LogServiceConfig
    {
        public IEnumerable<ILogAppender> Appenders { get; set; }
        public IEnumerable<ILogPropertyProvider> PropertyProviders { get; set; }
        public string LogTemplate { get; set; }
    }
}