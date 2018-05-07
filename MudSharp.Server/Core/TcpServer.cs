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
        private readonly IConfigProvider _configProvider;
        private readonly ILoggingProvider _loggingProvider;
        private bool _accept = false;
        private TcpListener _listener;

        public TcpServer(IConfigProvider configProvider, ILoggingProvider loggingProvider)
        {
            _configProvider = configProvider;
            _loggingProvider = loggingProvider;
        }

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

                _loggingProvider.LogMessage($"Listening for connections on port {_configProvider.Core.ListenPort}");
            }
            catch (Exception e)
            {
                _loggingProvider.LogMessage($"Caught exception at TcpClient.StartServer(): {e.Message}");
                _accept = false;
            }
        }

        /// <summary>
        /// Listens on the open TCP socket for new connections.
        /// </summary>
        public async void Listen()
        {
            if (_listener != null && _accept)
            {
                while (true)
                {
                    var clientTask = _listener.AcceptTcpClientAsync();

                    if (clientTask.Result != null)
                    {
                        var client = clientTask.Result;

                        _loggingProvider.LogMessage($"New connection from {client.Client.RemoteEndPoint.ToString()}");

                        await SessionManager.Instance.NewDescriptorAsync(client);
                    }
                }
            }
        }

        /// <summary>
        /// Processes input from the descriptor.
        /// </summary>
        /// <param name="descriptor"></param>
        public async void ProcessInputAsync(Descriptor descriptor)
        {
            
        }
    }
}
