using System.Net;
using System.Net.Sockets;

namespace WinFormsChatClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput(nameTextBox.Text, passwordTextBox.Text))
            {
                try
                {
                    this.Hide();

                    MainForm mf = new(nameTextBox.Text, passwordTextBox.Text, this);

                    if (!mf.IsDisposed)
                    {
                        mf.Show();
                    }
                }
                catch (SocketException) 
                { 
                    MessageBox.Show("Неможливо під'єднатися до сервера. Перевірте з'єднання та/або статус сервера.");
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Перевірте введені дані.");
            }
        }

        private bool ValidateInput(string nick, string pass)
        {
            if (nick == null || pass == null)
                return false;

            if (nick.Contains(' ') || pass.Contains(' '))
                return false;

            return true;
        }
    }
}