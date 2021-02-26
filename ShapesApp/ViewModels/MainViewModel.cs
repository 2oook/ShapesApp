﻿using GalaSoft.MvvmLight.Command;
using ShapesApp.Models;
using ShapesApp.Models.Creators;
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

        /// <summary>
        /// Метод для отображения всех фигур
        /// </summary>
        void ShowShapes() 
        {
            var circleCreator = new CircleCreator();
            var rectangleCreator = new RectangleCreator();
            var triangleCreator = new TriangleCreator();

            var drawStrategy = new ConcreteDrawStrategy();

            var shapes = new List<Shape>()
            {
                circleCreator.CreateShape(drawStrategy),
                rectangleCreator.CreateShape(drawStrategy),
                triangleCreator.CreateShape(drawStrategy)
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
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
