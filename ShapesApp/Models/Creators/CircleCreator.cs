using ShapesApp.Models.Drawable;
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
    /// Класс создателя окружностей
    /// </summary>
    class CircleCreator : ShapeCreator
    {
        public CircleCreator(ICircleDrawStrategy _circleDrawStrategy)
        {
            circleDrawStrategy = _circleDrawStrategy;
        }

        /// <summary>
        ///  Стратегия отображения окружности
        /// </summary>
        private ICircleDrawStrategy circleDrawStrategy;

        /// <summary>
        /// Метод для создания окружности
        /// </summary>
        /// <returns>Объект окружности</returns>
        public override Shape CreateShape(double x, double y)
        {
            return new Circle(circleDrawStrategy) { Point = new Point() { X = x, Y = y } };
        }
    }
}
