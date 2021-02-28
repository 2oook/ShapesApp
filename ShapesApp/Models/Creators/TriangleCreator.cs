using ShapesApp.Models.Drawable.Interfaces;
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
        /// Стратегия отображения треугольника
        /// </summary>
        private ITriangleDrawStrategy triangleDrawStrategy;

        /// <summary>
        /// Метод для создания треугольника
        /// </summary>
        /// <param name="x">Координата x фигуры</param>
        /// <param name="y">Координата y фигуры</param>
        /// <returns>Объект треугольника</returns>
        public override Shape CreateShape(double x, double y)
        {
            return new Triangle(triangleDrawStrategy) { Point = new Point() { X = x, Y = y } };
        }
    }
}
