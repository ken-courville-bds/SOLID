using SOLID.Math.Logging;
using SOLID.Math.Logging.Appenders;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using FluentAssertions.Collections;
using SOLID.Math.Logging.PropertyProviders;

namespace SOLID.MathTests
{
    public class LogServiceTest
    {
        private readonly ILogService sut;
        private readonly InMemoryAppender testAppender;

        public LogServiceTest()
        {
            this.testAppender = new InMemoryAppender();
            var appenders = new List<ILogAppender> { testAppender };
            var config = new LogServiceConfig
            {
                LogTemplate = "[{{username}}] - {{message}}",
                Appenders = new[] { testAppender },
                PropertyProviders = new[] { new UserNamePropertyProvider(() => "Joe Schmoe") }
            };
            sut = new LogService(config);
        }

        [Fact]
        public void AppendsLogEntryUsingTemplateAndPropertyProviders()
        {
            sut.Append("HELLO {0}", "WORLD");
            testAppender.Entries.Should().BeEquivalentTo(new[]
            {
                new LogEntry
                {
                    Message = "[Joe Schmoe] - HELLO WORLD"
                }
            });
        }
    }
}
