using System;

namespace SOLID.Math.Logging
{
    public class ConsoleLogger : ILogService
    {        
        public void Append(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}
