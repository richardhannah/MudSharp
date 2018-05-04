using MudSharp.Server.Providers;
using Ninject;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MudSharp.Server.Core
{
    /// <summary>
    /// TCP server.
    /// </summary>
    internal sealed class TcpServer
    {
        [Inject]
        private readonly IConfigProvider _configProvider;
        private bool _accept = false;
        private TcpListener _listener;

        /// <summary>
        /// Configures the TCP server and starts the listener.
        /// </summary>
        public void StartServer()
        {
            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1");
                _listener = new TcpListener(address, _configProvider.Core.ListenPort);

                _listener.Start();
                _accept = true;
            }
            catch (Exception e)
            {
                _accept = false;
            }
        }

        /// <summary>
        /// Listens on the open TCP socket for new connections.
        /// </summary>
        public void Listen()
        {
            if (_listener != null && _accept)
            {
                while (true)
                {
                    var clientTask = _listener.AcceptTcpClientAsync();

                    if (clientTask.Result != null)
                    {
                        var client = clientTask.Result;

                        // Set to non-blocking.
                        client.Client.Blocking = false;

                        SessionManager.Instance.NewDescriptor(client);
                    }
                }
            }
        }
    }
}
