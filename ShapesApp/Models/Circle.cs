using ShapesApp.Models.Interfaces;
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
    class Circle : Shape
    {
        public Circle(IDrawStrategy drawStrategy)
        {
            DrawStrategy = drawStrategy;
        }

        /// <summary>
        /// Высота
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width { get; set; }
    }
}
