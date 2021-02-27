using ShapesApp.Controls;
using ShapesApp.Models.Drawable;
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
    public class Circle : Shape
    {
        public Circle(ICircleDrawStrategy _circleDrawStrategy)
        {
            circleDrawStrategy = _circleDrawStrategy;
        }

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
