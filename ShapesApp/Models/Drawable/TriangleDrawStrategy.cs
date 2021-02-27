using ShapesApp.Controls;
using ShapesApp.Models.Drawable.Interfaces;

namespace ShapesApp.Models.Drawable
{
    /// <summary>
    /// Стратегия отображения треугольника
    /// </summary>
    public class TriangleDrawStrategy : ITriangleDrawStrategy
    {
        /// <summary>
        /// Метод для создания отображаемого объекта треугольника
        /// </summary>
        /// <param name="triangle">Объект треугольника<param>
        /// <returns>Отображаемый объект</returns>
        public object CreateDrawableTriangle(Triangle triangle)
        {
            var control = new TriangleControl();

            control.triangle.Points = triangle.Points;
            control.triangle.Stroke = triangle.Stroke;
            control.triangle.Fill = triangle.BackgroundColor;
            control.triangle.StrokeThickness = triangle.StrokeThickness;

            return control;
        }
    }
}
