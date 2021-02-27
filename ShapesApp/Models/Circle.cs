using ShapesApp.Models.Drawable.Interfaces;

namespace ShapesApp.Models
{
    /// <summary>
    /// Класс представляющий окружность
    /// </summary>
    public class Circle : Shape
    {
        public Circle(ICircleDrawStrategy _circleDrawStrategy)
        {
            circleDrawStrategy = _circleDrawStrategy;
        }

        /// <summary>
        /// Ссылка на объект стратегии отображения окружности
        /// </summary>
        ICircleDrawStrategy circleDrawStrategy { get; set; }

        /// <summary>
        /// Высота
        /// </summary>
        public double Height { get; set; } = 100;

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width { get; set; } = 100;

        /// <summary>
        /// Метод для создания отображаемого объекта
        /// </summary>
        /// <returns>Отображаемый объект окружности</returns>
        public override object CreateDrawableObject()
        {
            return circleDrawStrategy.CreateDrawableCircle(this);
        }
    }
}
