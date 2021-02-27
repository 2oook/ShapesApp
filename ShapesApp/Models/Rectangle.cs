using ShapesApp.Controls;
using ShapesApp.Models.Drawable.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp.Models
{
    /// <summary>
    /// Класс представляющий окружность
    /// </summary>
    public class Rectangle : Shape
    {
        public Rectangle(IRectangleDrawStrategy _rectangleDrawStrategy)
        {
            rectangleDrawStrategy = _rectangleDrawStrategy;
        }

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
