using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Server.Providers
{
    /// <inheritdoc />
    public class LocalAuthProvider : IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
