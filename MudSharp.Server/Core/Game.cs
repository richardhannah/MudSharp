using MudSharp.Server.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Server.Core
{
    internal sealed class Game
    {
        private readonly IConfigProvider _configProvider;
        private readonly ILoggingProvider _loggingProvider;
        private bool _running;
        private DateTime _gameStart;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="configProvider">The injected config provider to use.</param>
        /// <param name="loggingProvider">The injected logging provider to use.</param>
        public Game(IConfigProvider configProvider, ILoggingProvider loggingProvider)
        {
            _configProvider = configProvider;
            _loggingProvider = loggingProvider;
        }

        /// <summary>
        /// The main game loop.
        /// </summary>
        public void Run()
        {
            _running = true;
            _gameStart = DateTime.UtcNow;
            _loggingProvider.LogMessage("Entering main game loop");

            while (_running)
            {
                Heartbeat();
            }

            _loggingProvider.LogMessage("Starting game shutdown");
            PerformShutdown();
        }

        public void Shutdown()
        {
            _running = false;
        }

        private void PerformShutdown()
        {
            _loggingProvider.LogMessage("Shutdown complete");
            Environment.Exit(0);
        }

        private void Heartbeat()
        {
            var timeSinceStart = DateTime.UtcNow - _gameStart;

            if (timeSinceStart.TotalSeconds % _configProvider.Core.ZonePulseRateInSeconds == 0)
                PulseZones();

            if (timeSinceStart.TotalSeconds % _configProvider.Core.NpcPulseRateInSeconds == 0)
                PulseNpcs();

            if (timeSinceStart.TotalSeconds % _configProvider.Core.CombatPulseRateInSeconds == 0)
                PulseCombat();
        }

        private void PulseZones()
        {

        }


        private void PulseNpcs()
        {

        }


        private void PulseCombat()
        {

        }
    }
}
