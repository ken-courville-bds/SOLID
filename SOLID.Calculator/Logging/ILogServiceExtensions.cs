using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Math.Logging
{
    public static class ILogServiceExtensions
    {
        public static void Append(this ILogService logService, string format, params object[] args)
        {
            logService.Append(new LogEntry
            {
                Message = string.Format(format, args)
            });
        }
    }
}
