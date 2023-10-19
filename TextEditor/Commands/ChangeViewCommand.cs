using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TextEditor.Models;
using TextEditor.Services;
using TextEditor.Stores;
using TextEditor.ViewModels;

namespace TextEditor.Commands
{
    internal class ChangeViewCommand : ICommand
    {
        private NavigationMediator mediator;

        public ChangeViewCommand(NavigationMediator _mediator)
        {
            this.mediator = _mediator;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "Home":
                    {
                        mediator.CurrentViewModel = new StartupViewModel(mediator);
                        break;
                    }
                case "New":
                    {
                        if (!(mediator.CurrentViewModel is TextViewModel))
                            mediator.CurrentViewModel = new TextViewModel(mediator);

                        ICommand NewFileCommand = (ICommand)Application.Current.Resources["NewFileCommand"];

                        NewFileCommand.Execute(string.Empty);
                        break;
                    }
                case "Open":
                    {

                        OpenFileDialog dialog = DialogService.GetOpenFileDialog();

                        if (dialog.ShowDialog() == true)
                        {
                            if (!(mediator.CurrentViewModel is TextViewModel))
                                mediator.CurrentViewModel = new TextViewModel(mediator);

                            if (!((TextViewModel)mediator.CurrentViewModel).openedFiles.Any(f => f.FilePath == dialog.FileName))
                            {
                                ICommand NewFileCommand = (ICommand)Application.Current.Resources["NewFileCommand"];

                                NewFileCommand.Execute(dialog.FileName);
                            }
                        }

                        break;
                    }
                case "Save":
                    {
                        if (mediator.CurrentViewModel is TextViewModel model)
                        {
                            if (string.IsNullOrEmpty(model.CurrentTextFile.FilePath))
                            { 
                                SaveFileDialog dialog = DialogService.GetSaveFileDialog();

                                if (dialog.ShowDialog() == true)
                                {
                                    model.CurrentTextFile.FilePath = dialog.FileName;

                                    model.TextService.SaveFile(model.CurrentTextFile);
                                }
                            }
                            else
                            {
                                model.TextService.SaveFile(model.CurrentTextFile);
                            }
                        }

                        break;
                    }
                case "SaveAs":
                    {
                        if (mediator.CurrentViewModel is TextViewModel model)
                        {
                            SaveFileDialog dialog = DialogService.GetSaveFileDialog();

                            if (dialog.ShowDialog() == true)
                            {
                                model.CurrentTextFile.FilePath = dialog.FileName;

                                try
                                {
                                    model.TextService.SaveFile(model.CurrentTextFile);
                                }
                                catch (UnauthorizedAccessException)
                                {
                                    MessageBox.Show("Помилка: недостатньо прав для запису в задану директорію.");
                                }
                            }
                        }

                        break;
                    }
            }
        }
    }
}
