using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Math.Logging
{
    public class LogService : ILogService
    {
        private readonly LogServiceConfig config;

        public LogService(LogServiceConfig config)
        {
            this.config = config;
        }

        public void Append(string format, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
