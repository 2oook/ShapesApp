using ShapesApp.Infrastructure;
using ShapesApp.ViewModels;
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

            var editor = new Editor();
            mainWindow.Editor = editor;
            mainEntryPoint.Editor = editor;

            // Отобразить окно
            mainWindow.Show();
        }
    }
}
