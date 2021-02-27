using ShapesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
