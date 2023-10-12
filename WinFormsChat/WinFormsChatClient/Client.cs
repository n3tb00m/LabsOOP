using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;

namespace WinFormsChatClient
{
    internal class Client
    {
        private TextBox messagesTextBox = null!;

        private static Socket client = null!;

        private string nickname = "default";
        private string password = "password";

        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        private int storedmessages = 0;

        public Client(EndPoint endpoint, string nick, string pass, MainForm prnt)
        {
            nickname = nick ?? nickname;
            password = pass ?? password;

            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            client.Connect(endpoint);

            _ = PseudoHandshake();
        }

        private Client() { }

        public void SetTextBox(TextBox mtb)
        {
            messagesTextBox = mtb;
        }

        private async Task PseudoHandshake()
        {
            byte[] errorbuffer = new byte[128];

            client.Send(Encoding.UTF8.GetBytes(string.Format(nickname + ' ' + password)));

            client.Receive(errorbuffer, 0);

            string errormsg = Encoding.UTF8.GetString(errorbuffer);

            if (errormsg[..5] == "Error")
            {
                MessageBox.Show(errormsg);
                Dispose();
                Application.Exit();
            }
            else
            {
                await ListenForMessages();
            }
        }

        public void SendMessage(string msg)
        {
            byte[] msgbytes = Encoding.UTF8.GetBytes(msg);

            client.Send(msgbytes, 0);
        }

        private async Task ListenForMessages()
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                byte[] buffer = new byte[1_024];

                int received = await client.ReceiveAsync(buffer, 0);

                if (received == 0)
                {
                    Dispose();
                    Application.Exit();

                    break;
                }
                else
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, received);

                    messagesTextBox.AppendText(Environment.NewLine + message);

                    storedmessages++;
                }
            }
        }

        public void Disconnect()
        {
            client.Shutdown(SocketShutdown.Both);
            client.Disconnect(true);
            client.Close();
        }

        public bool IsConnected()
        {
            return client.Connected;
        }

        public void Dispose()
        {
            Disconnect();
            cancellationTokenSource.Cancel();
            client.Dispose();
        }
    }
}