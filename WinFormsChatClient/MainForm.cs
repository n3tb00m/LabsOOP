using System.Net;

namespace WinFormsChatClient
{
    public partial class MainForm : Form
    {
        private Client _client;
        private Form lg;

        public MainForm(string nick, string pass, Form login)
        {
            InitializeComponent();
            lg = login;
            _client = new Client(new IPEndPoint(IPAddress.Loopback, 4445), nick, pass, this);
            _client.SetTextBox(messagesTextBox);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (messageTextBox.Text.Length != 0)
            {
                _client.SendMessage(messageTextBox.Text);
                messageTextBox.Text = "";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.Dispose();
            lg.Close();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton.PerformClick();
            }
        }
    }
}