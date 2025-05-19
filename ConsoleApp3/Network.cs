using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp3
{
    internal class Network
    {
        TcpListener? listener = null;

        public Network()
        {
            listener = new TcpListener(IPAddress.Any, 8000);
        }

        public void Read(TcpClient client)
        {
            NetworkStream nstream = client.GetStream();

            byte[] buffer = new byte[1024];

            while (true)
            {
                int cnt = nstream.Read(buffer, 0, buffer.Length);

                if (cnt != 0)
                {
                    string str = Encoding.UTF8.GetString(buffer, 0, cnt);

                    Console.WriteLine(str);
                }
            }
        }

        public void Write(TcpClient client)
        { 
            NetworkStream nstream = client.GetStream();

            string? str = Console.ReadLine();

            byte[] buffer = Encoding.UTF8.GetBytes(str!);

            try
            {
                nstream.Write(buffer, 0, buffer.Length);
            }
            catch (Exception)
            {

            }
        public TcpClient Accept(TcpListener? listener)
        {
            return listener!.AcceptTcpClient();
        }
    }
}
