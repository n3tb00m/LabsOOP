using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TextEditor.Stores;
using TextEditor.ViewModels;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationMediator mediator = new NavigationMediator();

            mediator.CurrentViewModel = new StartupViewModel(mediator);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(mediator)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
