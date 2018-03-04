using System.Collections.Generic;

namespace SOLID.Math.Logging
{
    public class LogServiceConfig
    {
        private readonly IEnumerable<ILogAppender> appenders;
        private readonly IEnumerable<ILogFormatter> formatters;

        public LogServiceConfig(IEnumerable<ILogAppender> appenders, IEnumerable<ILogFormatter> formatters)
        {
            this.appenders = appenders;
            this.formatters = formatters;
        }
    }
}