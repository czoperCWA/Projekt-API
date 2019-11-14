using System;
using System.Collections.Generic;
using System.Text;

namespace Swizzer.Web.Infrustructure.Framework.Security
{
    public class SecuritySettings
    {
        public TimeSpan TokenDuration { get; set; }
        public string Key { get; set; }
    }
}
