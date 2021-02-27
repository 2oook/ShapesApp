using ShapesApp.Models.Drawable.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShapesApp.Models.Creators
{
    /// <summary>
    /// Класс создателя прямоугольников
    /// </summary>
    class RectangleCreator : ShapeCreator
    {
        public RectangleCreator(IRectangleDrawStrategy _rectangleDrawStrategy)
        {
            rectangleDrawStrategy = _rectangleDrawStrategy;
        }

        /// <summary>
        ///  Стратегия отображения прямоугольника
        /// </summary>
        private IRectangleDrawStrategy rectangleDrawStrategy;

        /// <summary>
        /// Метод для создания прямоугольника
        /// </summary>
        /// <returns>Объект прямоугольника</returns>
        public override Shape CreateShape(double x, double y)
        {
            return new Rectangle(rectangleDrawStrategy) { Point = new Point() { X = x, Y = y } };
        }
    }
}
