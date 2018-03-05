using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Math.Logging.PropertyProviders
{
    public class UserNamePropertyProvider : ILogPropertyProvider
    {
        private readonly Func<string> userProvider;

        public UserNamePropertyProvider(Func<string> userProvider)
        {
            this.userProvider = userProvider;
        }
        public void ApplyProperties(IDictionary<string, object> templateContext)
        {
            templateContext.Add("username", userProvider());
        }
    }
}
