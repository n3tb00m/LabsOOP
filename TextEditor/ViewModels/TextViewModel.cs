using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using TextEditor.Commands;
using TextEditor.Models;
using TextEditor.Services;
using TextEditor.Stores;

namespace TextEditor.ViewModels
{
    internal class TextViewModel : ViewModelBase
    {
        public ObservableCollection<TextFile> openedFiles { get; set; }
        public TextService TextService { get; set; } = null!;
        public TextFile? CurrentTextFile { get; set; }
        public string? CurrentText { get; set; }
        public ICommand UpdateViewCommand { get; }

        public TextViewModel(NavigationMediator _mediator)
        {
            UpdateViewCommand = new ChangeViewCommand(_mediator);

            openedFiles = new ObservableCollection<TextFile>();

            TextService = new TextService();
        }
    }
}
