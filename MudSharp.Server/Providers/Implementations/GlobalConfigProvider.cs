using Microsoft.Extensions.Configuration;
using MudSharp.Server.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MudSharp.Server.Providers
{
    /// <inheritdoc />
    internal sealed class GlobalConfigProvider : IConfigProvider
    {
        private IConfigurationRoot _config;

        private CoreConfiguration _coreConfig;


        #region Constructor

        public GlobalConfigProvider()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            _config = builder.Build();

            Load();
        }

        #endregion

        public CoreConfiguration Core => _coreConfig;


        #region Private helpers

        /// <summary>
        /// Loads the configuration into the respective config classes.
        /// </summary>
        private void Load()
        {
            _coreConfig = new CoreConfiguration()
            {
                ListenPort = int.Parse(_config["Core:ListenPort"]),
                SendBufferSize = int.Parse(_config["Core:SendBufferSize"]),
                NpcPulseRateInSeconds = int.Parse(_config["Core:NpcPulseRateInSeconds"]),
                ZonePulseRateInSeconds = int.Parse(_config["Core:ZonePulseRateInSeconds"]),
                CombatPulseRateInSeconds = int.Parse(_config["Core:CombatPulseRateInSeconds"])
            };
        }

        #endregion

    }
}
