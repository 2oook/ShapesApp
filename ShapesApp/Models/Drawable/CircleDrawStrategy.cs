using ShapesApp.Controls;
using ShapesApp.Models.Drawable.Interfaces;

namespace ShapesApp.Models.Drawable
{
    /// <summary>
    /// Стратегия отображения окружности
    /// </summary>
    public class CircleDrawStrategy : ICircleDrawStrategy
    {
        /// <summary>
        /// Метод для создания отображаемого объекта окружности
        /// </summary>
        /// <param name="circle">Объект окружности</param>
        /// <returns>Отображаемый объект</returns>
        public object CreateDrawableCircle(Circle circle)
        {
            var control = new CircleControl();

            control.circle.Height = circle.Height;
            control.circle.Width = circle.Width;
            control.circle.Stroke = circle.Stroke;
            control.circle.Fill = circle.BackgroundColor;
            control.circle.StrokeThickness = circle.StrokeThickness;

            return control;
        }
    }
}
