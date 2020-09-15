﻿using System.Net;

namespace MLAPI.Puncher.Server.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PuncherServer server = new PuncherServer();
            server.Transport = new MLAPI.Puncher.Shared.RufflesUDPTransport();
            server.Start(new IPEndPoint(IPAddress.Any, 6776));
        }
    }
}
