namespace ShapesApp.Models.Drawable.Interfaces
{
    /// <summary>
    /// Интерфейс стратегии отображения треугольника
    /// </summary>
    public interface ITriangleDrawStrategy
    {
        /// <summary>
        /// Метод для создания отображаемого объекта треугольника
        /// </summary>
        /// <param name="triangle">Объект треугольника</param>
        /// <returns>Отображаемый объект</returns>
        object CreateDrawableTriangle(Triangle triangle);
    }
}
