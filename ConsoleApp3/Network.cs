using System.Net;
using System.Net.Sockets;

namespace ConsoleApp3
{
    internal class Network
    {
        TcpListener? listener = null;

        public Network()
        {
            listener = new TcpListener(IPAddress.Any, 8000);
        }
    }
}
