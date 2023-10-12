using System.Net;

namespace WinFormsChatServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Server srv = new();
            srv.StartServer(new IPEndPoint(IPAddress.Loopback, 4445));
        }
    }
}