namespace ShapesApp.Models.Drawable.Interfaces
{
    /// <summary>
    /// Интерфейс стратегии отображения прямоугольника
    /// </summary>
    public interface IRectangleDrawStrategy
    {
        /// <summary>
        /// Метод для создания отображаемого объекта прямоугольника
        /// </summary>
        /// <param name="rectangle">Объект прямоугольника<param>
        /// <returns>Отображаемый объект</returns>
        object CreateDrawableRectangle(Rectangle rectangle);
    }
}
