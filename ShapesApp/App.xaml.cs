using ShapesApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ShapesApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Создать главное окно
            var mainWindow = new MainWindow();
            // Создать главную VM
            var mainEntryPoint = new MainViewModel();
            mainWindow.DataContext = mainEntryPoint;
            // Отобразить окно
            mainWindow.Show();
        }
    }
}
