using MudSharp.Server.Core;
using MudSharp.Server.Providers;
using Ninject;
using Ninject.Activation;
using Ninject.Infrastructure.Disposal;
using System;
using System.Threading;

namespace MudSharp.Server
{
    class Program
    {
        private static IKernel _kernel;

        static void Main(string[] args)
        {
            ConfigureNinject();

            var server = new TcpServer(_kernel.Get<IConfigProvider>(), _kernel.Get<ILoggingProvider>());
            server.StartServer();
            server.Listen();
        }

        #region DI Configuration
        /// <summary>
        /// Configures the Ninject container.
        /// </summary>
        private static void ConfigureNinject()
        {
            _kernel = new StandardKernel();

            // Core
            _kernel.Bind<IConfigProvider>().To<GlobalConfigProvider>();
            _kernel.Bind<IAuthProvider>().To<LocalAuthProvider>();
            _kernel.Bind<ILoggingProvider>().To<LocalLoggingProvider>();
        }

        #endregion
    }
}
