using MudSharp.Data.Models.World.Actors;
using MudSharp.Server.Providers;
using Ninject;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
        /// The injected logging provider to use.
        /// </summary>
        [Inject]
        private ILoggingProvider _loggingProvider;

        /// <summary>
        /// Constructor.
        /// </summary>
        private SessionManager()
        {
            Descriptors = new HashSet<Descriptor>();
            CurrentPlayers = new KeyValuePair<string, Player>();
        }


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

        /// <summary>
        /// Creates a new <see cref="Descriptor"/> from the <see cref="TcpClient"/>.
        /// </summary>
        /// <param name="client">The <see cref="TcpClient"/> to create the descriptor from.</param>
        public async Task NewDescriptorAsync(TcpClient client)
        {
            var newDescriptor = new Descriptor(client);
            Descriptors.Add(newDescriptor);

            await newDescriptor.SendAsync("Username (new for new account): ");
        }

        #endregion
    }
}
