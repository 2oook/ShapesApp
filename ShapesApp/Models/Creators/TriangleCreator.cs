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
    /// Класс создателя треугольников
    /// </summary>
    class TriangleCreator : ShapeCreator
    {
        public TriangleCreator(ITriangleDrawStrategy _triangleDrawStrategy)
        {
            triangleDrawStrategy = _triangleDrawStrategy;
        }

        /// <summary>
        ///  Стратегия отображения треугольника
        /// </summary>
        private ITriangleDrawStrategy triangleDrawStrategy;

        /// <summary>
        /// Метод для создания треугольника
        /// </summary>
        /// <returns>Объект треугольника</returns>
        public override Shape CreateShape(double x, double y)
        {
            return new Triangle(triangleDrawStrategy) { Point = new Point() { X = x, Y = y } };
        }
    }
}
