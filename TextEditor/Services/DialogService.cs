using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Services
{
    public static class DialogService
    {
        public static OpenFileDialog GetOpenFileDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.AddExtension = true;
            dialog.DefaultExt = "Text Document (*.txt)|*.txt";
            dialog.CheckFileExists = true;
            dialog.Filter = "Text Document (*.txt)|*.txt;|Rich Text Document (*.rtf)|*.rtf;";

            return dialog;
        }

        public static SaveFileDialog GetSaveFileDialog()
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.AddExtension = true;
            dialog.DefaultExt = "Text Document (*.txt)|*.txt";
            dialog.Filter = "Text Document (*.txt)|*.txt;|Rich Text Document (*.rtf)|*.rtf;";

            return dialog;
        }
    }
}
