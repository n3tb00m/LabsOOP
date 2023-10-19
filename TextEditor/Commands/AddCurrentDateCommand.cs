using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace TextEditor.Commands
{
    public class AddCurrentDateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is RichTextBox richTextBox)
            {
                TextRange textRange = new TextRange(richTextBox.CaretPosition, richTextBox.CaretPosition);
                textRange.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }
    }

}
