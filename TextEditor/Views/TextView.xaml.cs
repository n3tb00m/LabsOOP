using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TextEditor.Helper;
using TextEditor.Models;
using TextEditor.ViewModels;

namespace TextEditor.Views
{
    /// <summary>
    /// Interaction logic for TextView.xaml
    /// </summary>
    public partial class TextView : UserControl
    {
        public TextView()
        {
            InitializeComponent();
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabControl.SelectedItem is TextFile textFile)
            {
                if (Application.Current.MainWindow.DataContext is MainViewModel vm && vm.SelectedViewModel is TextViewModel model)
                {
                    if (model.CurrentTextFile?.FilePath != textFile.FilePath)
                    {
                        if (model.CurrentTextFile != null)
                        {
                            model.CurrentTextFile.Text = textArea.Document;
                        }

                        model.CurrentTextFile = textFile;

                        var doc = textFile.Text;

                        if (doc != null) textArea.Document = doc;
                    }
                }
            }
        }

        private void textArea_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextPointer tp1 = textArea.Selection.Start.GetLineStartPosition(0);
            TextPointer tp2 = textArea.Selection.Start;

            int column = tp1.GetOffsetToPosition(tp2);
            int someBigNumber = int.MaxValue;
            int lineMoved = 0;

            textArea.Selection.Start.GetLineStartPosition(-someBigNumber, out lineMoved);
            int currentLineNumber = 1 - lineMoved;
            currentRow.Text = "Row: " + currentLineNumber.ToString();
            currentColumn.Text = "Column: " + column.ToString();
        }
    }
}
