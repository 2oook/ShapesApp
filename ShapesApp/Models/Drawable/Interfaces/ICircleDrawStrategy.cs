namespace ShapesApp.Models.Drawable.Interfaces
{
    /// <summary>
    /// Интерфейс стратегии отображения окружности
    /// </summary>
    public interface ICircleDrawStrategy
    {
        /// <summary>
        /// Метод для создания отображаемого объекта окружности
        /// </summary>
        /// <param name="circle">Объект окружности</param>
        /// <returns>Отображаемый объект</returns>
        object CreateDrawableCircle(Circle circle);
    }
}
