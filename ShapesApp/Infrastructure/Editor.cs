using ShapesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ShapesApp.Infrastructure
{
    /// <summary>
    /// Класс представляющий редактор
    /// </summary>
    public class Editor : IEditor
    {
        /// <summary>
        /// Ссылка на объект Canvas
        /// </summary>
        public Canvas Canvas { get; set; }

        /// <summary>
        /// Метод для отображения фигуры
        /// </summary>
        /// <param name="shape">Объект фигуры</param>
        public void DrawShape(Shape shape) 
        {
            var drawableShape = shape.CreateDrawableObject() as UIElement;
            Canvas.SetLeft(drawableShape, shape.Point.X);
            Canvas.SetTop(drawableShape, shape.Point.Y);
            Canvas.Children.Add(drawableShape);
        }
    }
}
