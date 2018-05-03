using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Server.Providers
{
    /// <inheritdoc />
    internal sealed class LocalAuthProvider : IAuthProvider
    {
        /// <inheritdoc />
        public bool Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
