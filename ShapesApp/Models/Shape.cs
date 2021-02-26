using ShapesApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;

namespace ShapesApp.Models
{
    /// <summary>
    /// Базовый класс фигур
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Объект стратегии отрисовки фигуры
        /// </summary>
        protected IDrawStrategy DrawStrategy { get; set; }

        /// <summary>
        /// Цвет линии контура
        /// </summary>
        public Stroke Stroke { get; set; }

        /// <summary>
        /// Толщина линии контура
        /// </summary>
        public double StrokeThickness { get; set; }

        /// <summary>
        /// Метод для отрисовки фигуры
        /// </summary>
        public void Draw() 
        {
            DrawStrategy.Draw();
        }
    }
}
