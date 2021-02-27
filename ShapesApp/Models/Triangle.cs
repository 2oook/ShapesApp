using ShapesApp.Models.Drawable.Interfaces;
using System.Windows;
using System.Windows.Media;

namespace ShapesApp.Models
{
    /// <summary>
    /// Класс представляющий треугольник
    /// </summary>
    public class Triangle : Shape
    {
        public Triangle(ITriangleDrawStrategy _triangleDrawStrategy)
        {
            triangleDrawStrategy = _triangleDrawStrategy;
        }

        /// <summary>
        /// Ссылка на объект стратегии отображения треугольника
        /// </summary>
        private ITriangleDrawStrategy triangleDrawStrategy;

        /// <summary>
        /// Коллекция точек описывающих форму треугольника
        /// </summary>
        public PointCollection Points { get; set; } = new PointCollection()
        {
            new Point(){ X = 50, Y = 0 },
            new Point(){ X = 0, Y = 100 },
            new Point(){ X = 100, Y = 100 },
            new Point(){ X = 50, Y = 0 },
        };

        /// <summary>
        /// Метод для создания отображаемого объекта
        /// </summary>
        /// <returns>Отображаемый объект треугольника</returns>
        public override object CreateDrawableObject()
        {
            return triangleDrawStrategy.CreateDrawableTriangle(this);
        }
    }
}
