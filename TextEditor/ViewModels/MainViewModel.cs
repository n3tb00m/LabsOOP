using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TextEditor.Commands;
using TextEditor.Stores;

namespace TextEditor.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        public readonly NavigationMediator mediator;
        private ViewModelBase _selectedViewModel;
        public ViewModelBase SelectedViewModel => mediator.CurrentViewModel;

        public MainViewModel(NavigationMediator _mediator)
        {
            mediator = _mediator;

            mediator.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(SelectedViewModel));
        }
    }
}
