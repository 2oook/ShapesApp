using ShapesApp.Controls;
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
        /// <summary>
        /// Высота
        /// </summary>
        public double Height { get; set; } = 100;

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width { get; set; } = 100;

        public override object CreateDrawableObject()
        {
            var control = new CircleControl();

            control.circle.Height = Height;
            control.circle.Width = Width;
            control.circle.Stroke = Stroke;
            control.circle.Fill = BackgroundColor;
            control.circle.StrokeThickness = StrokeThickness;

            return control;
        }
    }
}
