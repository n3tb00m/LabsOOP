using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsChatServer
{
    internal class Server
    {
        private Dictionary<Socket, string> users = new();
        private List<string> messages = new();
        private readonly string password = "1234";

        enum ActionCodes
        {
            SYNC = 199,
            OK = 200,
            ALREADYCONNECTED = 444
        }

        public Server()
        {
        }

        private bool ConfirmConnection(Socket handler)
        {
            byte[] loginbuffer = new byte[1_024];

            handler.Receive(loginbuffer, SocketFlags.None);

            string[] credentials = Encoding.UTF8.GetString(loginbuffer).Split(' ');

            if (!string.Equals(credentials[1], password, StringComparison.InvariantCulture))
            {
                handler.Send(Encoding.UTF8.GetBytes($"Error: wrong password."));

                handler.Close();
                handler.Dispose();

                return false;
            }

            if (users.Values.Contains(credentials[0]))
            {
                handler.Send(Encoding.UTF8.GetBytes("Error: user with this name is already connected. "
                    + ((int)ActionCodes.ALREADYCONNECTED).ToString()));

                handler.Close();
                handler.Dispose();

                return false;
            }

            handler.Send(Encoding.UTF8.GetBytes("All okay! " + ((int)ActionCodes.OK).ToString()));

            BroadcastMessage(Encoding.UTF8.GetBytes(credentials[0] + " connected."));

            Console.WriteLine(credentials[0] + " connected.");

            users.Add(handler, credentials[0]);
            return true;
        }

        private void BroadcastMessage(byte[] message)
        {
            foreach (var socket in users)
            {
                socket.Key.Send(message, SocketFlags.None);
            }
        }

        public void StartServer(IPEndPoint ip)
        {
            using (Socket listener = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp))
            {
                listener.Bind(ip);
                listener.Listen(10);

                while (true)
                {
                    Socket handler = listener.Accept();

                    if (ConfirmConnection(handler))
                    {
                        try
                        {
                            _ = HandleClient(handler);
                        }
                        catch (SocketException ex)
                        {
                            Console.WriteLine("socketexception: " + ex.Message);
                            users.Remove(handler);
                            handler.Close();
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine("exception");
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }

        private async Task HandleClient(Socket handler)
        {
            while (true)
            {
                byte[] buffer = new byte[1_024];

                int received = await handler.ReceiveAsync(buffer, SocketFlags.None);

                string message = Encoding.UTF8.GetString(buffer, 0, received);

                if (received == 0)
                {
                    await Task.Run(() => HandleStatus(handler));
                }
                else
                {
                    messages.Add(users[handler] + ": " + message);

                    Console.WriteLine(messages.Last());

                    BroadcastMessage(Encoding.UTF8.GetBytes(messages.Last()));
                }
            }
        }

        private async Task HandleStatus(Socket handler)
        {
            byte[] buffer = new byte[64];

            int received = handler.Receive(buffer, SocketFlags.None);

            if (received == 0)
            {
                string dcmsg = $"{users[handler]} disconnected.";

                users.Remove(handler);

                BroadcastMessage(Encoding.UTF8.GetBytes(dcmsg));
                System.Console.WriteLine(dcmsg);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
                handler.Dispose();
            }

            string status = Encoding.UTF8.GetString(buffer, 0, received);

            if (status[..3] == ((int)ActionCodes.SYNC).ToString())
            {
                int diffcount = messages.Count - int.Parse(status[3..]);

                List<string> difflist = messages.GetRange(messages.Count - diffcount, diffcount);

                string diffrespond = JsonSerializer.Serialize(difflist);

                byte[] diffbytes = Encoding.UTF8.GetBytes(diffrespond);

                await handler.SendAsync(diffbytes, SocketFlags.None);
            }
        }
    }
}