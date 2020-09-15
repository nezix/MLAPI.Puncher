using System.Net;
using System.Net.Sockets;
using Ruffles.Connections;
using Ruffles.Configuration;
using Ruffles.Core;
using Ruffles.Channeling;

namespace MLAPI.Puncher.Shared
{
    /// <summary>
    /// Default UDP transport implementation
    /// </summary>
    public class RufflesUDPTransport : IUDPTransport
    {
        private RuffleSocket socket;

        /// <summary>
        /// Binds the UDP socket to the specified local endpoint.
        /// </summary>
        /// <param name="endpoint">The local endpoint to bind to.</param>
        public void Bind(IPEndPoint endpoint)
        {
                // Setup the socket info here
            socket = new RuffleSocket(new SocketConfig()
            {
                AllowBroadcasts = true, //necessary ?
                AllowUnconnectedMessages = true, //necessary ?
                DualListenPort = endpoint.Port
            });

            // Bind the socket
            socket.Start();
        }

        /// <summary>
        /// Closes the UDP socket.
        /// </summary>
        public void Close()
        {
            // Close the socket
            socket.Stop();
        }

        /// <summary>
        /// Receives bytes from endpoint.
        /// </summary>
        /// <returns>The amount of bytes received. 0 or elss if failed.</returns>
        /// <param name="buffer">The buffer to receive to.</param>
        /// <param name="offset">The offer of the buffer to receive at.</param>
        /// <param name="length">The max length to receive.</param>
        /// <param name="timeoutMs">The operation timeout in milliseconds.</param>
        /// <param name="endpoint">The endpoint the packet came from.</param>
        public int ReceiveFrom(byte[] buffer, int offset, int length, int timeoutMs, out IPEndPoint endpoint)
        {
            endpoint = null;
            return -1;
        }

        /// <summary>
        /// Sends bytes to endpoint.
        /// </summary>
        /// <returns>The bytes sent. 0 or less if failed.</returns>
        /// <param name="buffer">The buffer to send.</param>
        /// <param name="offset">The offset of the buffer to start sending at.</param>
        /// <param name="length">The length to send from the buffer.</param>
        /// <param name="timeoutMs">The operation timeout in milliseconds.</param>
        /// <param name="endpoint">The endpoint to send to.</param>
        public int SendTo(byte[] buffer, int offset, int length, int timeoutMs, IPEndPoint endpoint)
        {
            return -1;
        }
    }
}
