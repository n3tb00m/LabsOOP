using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using TextEditor.Models;
using TextEditor.ViewModels;

namespace TextEditor.Commands
{
    internal class NewFileCommand : ICommand
    {
        public NewFileCommand()
        {
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if ((MainViewModel)Application.Current.MainWindow.DataContext is MainViewModel vm && vm != null)
            {
                string filepath = parameter?.ToString();

                if (vm.SelectedViewModel is TextViewModel model)
                {
                    if (string.IsNullOrEmpty(filepath))
                    {
                        if (!model.openedFiles.Any(t => t.FileName == "New File*"))
                            model.openedFiles.Add(new TextFile(filepath));
                    }
                    else model.openedFiles.Add(new TextFile(filepath));
                }
                else if (vm.SelectedViewModel is StartupViewModel)
                {
                    vm.mediator.CurrentViewModel = new TextViewModel(vm.mediator);

                    ((TextViewModel)vm.SelectedViewModel).openedFiles.Add(((TextViewModel)vm.SelectedViewModel).CurrentTextFile);
                }
            }
        }
    }
}
