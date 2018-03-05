using HandlebarsDotNet;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace SOLID.Math.Logging
{
    public class LogService : ILogService
    {
        private readonly LogServiceConfig config;

        private IEnumerable<ILogAppender> Appenders =>
            config.Appenders ?? new List<ILogAppender>();
        private IEnumerable<ILogPropertyProvider> PropertyProviders =>
            config.PropertyProviders ?? new List<ILogPropertyProvider>();

        private IHandlebars templateEngine;
        private readonly Func<object, string> template;

        public LogService(LogServiceConfig config)
        {
            this.config = config;

            templateEngine = Handlebars.Create();
            this.template = templateEngine.Compile(this.config.LogTemplate);
        }

        public void Append(LogEntry entry)
        {
            IDictionary<string, object> templateContext = new Dictionary<string, object>
            {
                {"message", entry.Message},
            };
            foreach (var item in PropertyProviders)
            {
                item.ApplyProperties(templateContext);
            }
            entry.Message = template(templateContext);
            foreach (var appender in Appenders)
            {
                appender.Append(entry);
            }
        }
    }
}
