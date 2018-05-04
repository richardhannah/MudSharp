using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Server.Configuration
{
    public class CoreConfiguration
    {
        public int ListenPort { get; set; }
        public int SendBufferSize { get; set; }
    }
}
