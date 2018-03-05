using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Math.Logging.Appenders
{
    public class InMemoryAppender : ILogAppender
    {
        public InMemoryAppender()
        {
            Entries = new List<LogEntry>();
        }

        public ICollection<LogEntry> Entries { get; set; }

        public void Append(LogEntry entry)
        {
            Entries.Add(entry);
        }
    }
}
