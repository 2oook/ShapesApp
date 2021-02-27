using ShapesApp.Models;
using System.Windows.Controls;

namespace ShapesApp.Infrastructure
{
    /// <summary>
    /// Интерфейс редактора
    /// </summary>
    public interface IEditor
    {
        /// <summary>
        /// Ссылка на объект Canvas
        /// </summary>
        Canvas Canvas { get; set; }

        /// <summary>
        /// Метод для отображения фигуры
        /// </summary>
        /// <param name="shape">Объект фигуры</param>
        void DrawShape(Shape shape);
    }
}
