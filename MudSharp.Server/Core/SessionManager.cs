using MudSharp.Data.Models.World.Actors;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace MudSharp.Server.Core
{
    /// <summary>
    /// Singleton for managing session states throughout the game.
    /// </summary>
    internal sealed class SessionManager
    {
        /// <summary>
        /// The instance of the <see cref="SessionManager"/>.
        /// </summary>
        private static SessionManager _instance = null;

        /// <summary>
        /// Lock object for thread safety.
        /// </summary>
        private static readonly object _lockObject = new object();

        /// <summary>
        /// Constructor.
        /// </summary>
        private SessionManager() { }


        /// <summary>
        /// Gets the current <see cref="SessionManager"/> instance.
        /// </summary>
        public static SessionManager Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new SessionManager();
                    }

                    return _instance;
                }
            }
        }

        #region Properties

        public HashSet<Descriptor> Descriptors { get; set; }
        public KeyValuePair<string, Player> CurrentPlayers { get; set; }

        #endregion


        #region Public Methods

        public void NewDescriptor(TcpClient client)
        {
            var newDescriptor = new Descriptor(client);
            Descriptors.Add(newDescriptor);
        }

        #endregion
    }
}
