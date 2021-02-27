using GalaSoft.MvvmLight.Command;
using ShapesApp.Infrastructure;
using ShapesApp.Models;
using ShapesApp.Models.Creators;
using ShapesApp.Models.Drawable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShapesApp.ViewModels
{
    /// <summary>
    /// Главная модель представления
    /// </summary>
    class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            InitializeCommands();
        }

        /// <summary>
        /// Ссылка на объект редактора
        /// </summary>
        public IEditor Editor { get; set; }

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

        /// <summary>
        /// Метод для отображения всех фигур
        /// </summary>
        void ShowShapes() 
        {
            var circleCreator = new CircleCreator(new CircleDrawStrategy());
            var rectangleCreator = new RectangleCreator(new RectangleDrawStrategy());
            var triangleCreator = new TriangleCreator(new TriangleDrawStrategy());

            var shapes = new List<Shape>()
            {
                circleCreator.CreateShape(10, 20),
                rectangleCreator.CreateShape(150, 50),
                triangleCreator.CreateShape(370,40)
            };

            foreach (var shape in shapes)
            {
                Editor.DrawShape(shape);
            }
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
