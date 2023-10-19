﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor.ViewModels;

namespace TextEditor.Stores
{
    internal class NavigationMediator
    {
        private ViewModelBase _currentViewModel;
        public event Action CurrentViewModelChanged;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                //_currentViewModel?.Dispose();
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
