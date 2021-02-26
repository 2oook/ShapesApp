using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShapesApp.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            InitializeCommands();
        }

        private string progressState = string.Empty;

        public string ProgressState
        {
            get { return progressState; }
            set
            {
                progressState = value;
                RaisePropertyChanged(nameof(ProgressState));
            }
        }

        private ICommand showShapesCommand;
        /// <summary>
        /// Команда для отображения фигур
        /// </summary>
        public ICommand ShowShapesCommand
        {
            get { return showShapesCommand; }
            set
            {
                showShapesCommand = value;
                RaisePropertyChanged(nameof(ShowShapesCommand));
            }
        }

        /// <summary>
        /// Метод для инициализации команд
        /// </summary>
        private void InitializeCommands()
        {
            ShowShapesCommand = new RelayCommand(ShowShapes);
        }

        void ShowShapes() 
        {

        }

        /// <summary>
        /// Ссылка на обработчик события изменения свойства
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Метод для поднятия события изменения свойства
        /// </summary>
        /// <param name="propName">Имя свойства</param>
        protected virtual void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
