using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Server.Providers
{
    public class LocalLoggingProvider : ILoggingProvider
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
