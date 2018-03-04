using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Math
{
    public class ConsoleLogger : ILog
    {        
        public void Append(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}
