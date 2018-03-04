using System;

namespace SOLID.Math.Logging
{
    public class ConsoleLogger : ILog
    {        
        public void Append(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}
