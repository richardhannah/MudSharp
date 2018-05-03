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
        static void Main(string[] args)
        {
            ConfigureNinject();
        }

        #region DI Configuration
        /// <summary>
        /// Configures the Ninject DI container.
        /// </summary>
        private static void ConfigureNinject()
        {
            IKernel kernel = new StandardKernel();

            // Authentication
            kernel.Bind<IAuthProvider>().To<LocalAuthProvider>();

            // Configuration
            kernel.Bind<IConfigProvider>().To<GlobalConfigProvider>()
                .InSingletonScope();
        }

        #endregion
    }
}
