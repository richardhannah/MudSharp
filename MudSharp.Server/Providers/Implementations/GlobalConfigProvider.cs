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

        #region Properties

        /// <summary>
        /// Core game configuration.
        /// </summary>
        public CoreConfiguration Core { get; private set; }

        /// <summary>
        /// Game world configuration.
        /// </summary>
        public WorldConfiguration World { get; private set; }

        #endregion


        #region Private helpers

        /// <summary>
        /// Loads the configuration into the respective config classes.
        /// </summary>
        private void Load()
        {
            Core = new CoreConfiguration()
            {
                ListenAddress = _config["Core:ListenAddress"] ?? "127.0.0.1",
                ListenPort = int.Parse(_config["Core:ListenPort"]),
                SendBufferSize = int.Parse(_config["Core:SendBufferSize"]),
                NpcPulseRateInSeconds = int.Parse(_config["Core:NpcPulseRateInSeconds"]),
                ZonePulseRateInSeconds = int.Parse(_config["Core:ZonePulseRateInSeconds"]),
                CombatPulseRateInSeconds = int.Parse(_config["Core:CombatPulseRateInSeconds"]),
                AutosavePulseRateInSeconds = int.Parse(_config["Core:AutosavePulseRateInSeconds"])
            };

            World = new WorldConfiguration()
            {
                DefaultStartRoom = int.Parse(_config["World:DefaultStartRoom"])
            };
        }

        #endregion

    }
}
