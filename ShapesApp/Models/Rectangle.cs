using ShapesApp.Models.Drawable.Interfaces;

namespace ShapesApp.Models
{
    /// <summary>
    /// Класс представляющий окружность
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Конструктор объекта прямоугольника
        /// </summary>
        /// <param name="_rectangleDrawStrategy">Стратегия отображения прямоугольника</param>
        public Rectangle(IRectangleDrawStrategy _rectangleDrawStrategy)
        {
            rectangleDrawStrategy = _rectangleDrawStrategy;
        }

        /// <summary>
        /// Ссылка на объект стратегии отображения прямоугольника
        /// </summary>
        private IRectangleDrawStrategy rectangleDrawStrategy;

        /// <summary>
        /// Высота
        /// </summary>
        public double Height { get; set; } = 100;

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width { get; set; } = 200;

        /// <summary>
        /// Метод для создания отображаемого объекта
        /// </summary>
        /// <returns>Отображаемый объект прямоугольника</returns>
        public override object CreateDrawableObject()
        {
            return rectangleDrawStrategy.CreateDrawableRectangle(this);
        }
    }
}
