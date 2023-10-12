using Antlr4.Runtime.Atn;
using System.Text;

namespace Lab1_2
{
    public partial class Form1 : Form
    {
        private StringBuilder buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buffer = new StringBuilder();
            resultLabel.Text = null;
        }

        private void OnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                Roflan(btn.Text);
            }
            catch (Exception)
            {
                resultLabel.Text = "ERROR";
                buffer.Clear();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Back) Roflan("C");
                else Roflan(e.KeyChar.ToString());
            }
            catch (Exception)
            {
                resultLabel.Text = "ERROR";
                buffer.Clear();
            }
        }

        private void Roflan(string action)
        {
            switch (action)
            {
                case "+":
                case "-":
                case "/":
                case "*":
                case "(":
                case ")":
                case "0":
                case "1":
                    buffer.Append(action);
                    break;
                case "C":
                    if (buffer.Length > 0)
                        buffer = buffer.Remove(buffer.Length - 1, 1);
                    break;
                case "AC":
                    buffer.Clear();
                    break;
                case "=":
                    if (buffer.ToString().Count(c => c == '(' || c == ')') % 2 != 0) return;
                    buffer.Replace(buffer.ToString(), Calculator.Calculate(buffer.ToString()));
                    break;
                default: return;
            }
            if (buffer != null) resultLabel.Text = buffer.ToString();
        }
    }
}