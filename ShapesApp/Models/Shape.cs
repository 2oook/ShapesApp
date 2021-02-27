using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ShapesApp.Models
{
    /// <summary>
    /// Базовый класс фигур
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Цвет фона фигуры
        /// </summary>
        public Brush BackgroundColor { get; set; } = Brushes.AliceBlue;

        /// <summary>
        /// Цвет линии контура
        /// </summary>
        public Brush Stroke { get; set; } = Brushes.Black;

        /// <summary>
        /// Толщина линии контура
        /// </summary>
        public double StrokeThickness { get; set; } = 2;

        /// <summary>
        /// Координаты фигуры
        /// </summary>
        public Point Point { get; set; }

        /// <summary>
        /// Метод для создания отображаемого объекта
        /// </summary>
        /// <returns>Отображаемый объект</returns>
        public abstract object CreateDrawableObject();
    }
}
