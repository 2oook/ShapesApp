namespace ShapesApp.Models.Creators
{
    /// <summary>
    /// Базовый класс создателей форм
    /// </summary>
    abstract class ShapeCreator
    {
        /// <summary>
        /// Метод для создания формы
        /// </summary>
        /// <param name="x">Координата x фигуры</param>
        /// <param name="y">Координата y фигуры</param>
        /// <returns>Объект формы</returns>
        public abstract Shape CreateShape(double x, double y);
    }
}
