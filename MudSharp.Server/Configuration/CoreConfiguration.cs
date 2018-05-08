using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Server.Configuration
{
    public class CoreConfiguration
    {
        /// <summary>
        /// The IP address the game will listen on.
        /// </summary>
        public string ListenAddress { get; set; }

        /// <summary>
        /// The TCP port the game will listen on.
        /// </summary>
        public int ListenPort { get; set; }

        /// <summary>
        /// The size of the socket send buffer, per descriptor.
        /// </summary>
        public int SendBufferSize { get; set; }

        /// <summary>
        /// The number of seconds between pulses when NPC actions should be processed.
        /// </summary>
        public int NpcPulseRateInSeconds { get; set; }

        /// <summary>
        /// The number of seconds between pulses when combat is occurring.
        /// </summary>
        public int CombatPulseRateInSeconds { get; set; }

        /// <summary>
        /// The number of seconds between pulses when processing zones (weather, etc...)
        /// </summary>
        public int ZonePulseRateInSeconds { get; set; }

        /// <summary>
        /// The number of seconds between player autosaves.
        /// </summary>
        public int AutosavePulseRateInSeconds { get; set; }
 
    }
}
