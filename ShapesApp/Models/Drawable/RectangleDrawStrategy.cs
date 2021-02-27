using ShapesApp.Controls;
using ShapesApp.Models.Drawable.Interfaces;

namespace ShapesApp.Models.Drawable
{
    /// <summary>
    /// Стратегия отображения прямоугольника
    /// </summary>
    public class RectangleDrawStrategy : IRectangleDrawStrategy
    {
        /// <summary>
        /// Метод для создания отображаемого объекта прямоугольника
        /// </summary>
        /// <param name="rectangle">Объект прямоугольника<param>
        /// <returns>Отображаемый объект</returns>
        public object CreateDrawableRectangle(Rectangle rectangle)
        {
            var control = new RectangleControl();

            control.rect.Height = rectangle.Height;
            control.rect.Width = rectangle.Width;
            control.rect.Stroke = rectangle.Stroke;
            control.rect.Fill = rectangle.BackgroundColor;
            control.rect.StrokeThickness = rectangle.StrokeThickness;

            return control;
        }
    }
}
