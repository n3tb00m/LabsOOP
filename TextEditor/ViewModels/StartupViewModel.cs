using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.TextFormatting;
using TextEditor.Commands;
using TextEditor.Models;
using TextEditor.Services;
using TextEditor.Stores;

namespace TextEditor.ViewModels
{
    internal class StartupViewModel : ViewModelBase
    {
        public ObservableCollection<TextFile> RecentFiles { get; set; }
        public TextService TextService { get; set; } = null!;
        public ICommand UpdateViewCommand { get; }

        public StartupViewModel(NavigationMediator _mediator)
        {
            UpdateViewCommand = new ChangeViewCommand(_mediator);
        }

        public void LoadFiles()
        {
            if (File.Exists(("recent.json")))
            {
                try
                {
                    RecentFiles = new ObservableCollection<TextFile>(TextService.LoadRecentFiles("recent.json"));
                }
                catch (JsonException)
                {
                    RecentFiles = new ObservableCollection<TextFile>();
                }
            }
            else
                RecentFiles = new ObservableCollection<TextFile>();
        }
    }
}
