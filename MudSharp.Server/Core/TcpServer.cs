using MudSharp.Server.Providers;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MudSharp.Server.Core
{
    internal sealed class TcpServer
    {
        private readonly IConfigProvider _configProvider;
        private bool _accept = false;
        private TcpListener _listener;

        #region Constructor

        public TcpServer(IConfigProvider configProvider)
        {
            _configProvider = configProvider;
        }

        #endregion

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

        public void Listen()
        {
            if (_listener != null && _accept)
            {
                var clientTask = _listener.AcceptTcpClientAsync();
            }
        }
    }
}
