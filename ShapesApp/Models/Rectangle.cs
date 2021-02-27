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
    class Rectangle : Shape
    {
        /// <summary>
        /// Высота
        /// </summary>
        public double Height { get; set; } = 100;

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width { get; set; } = 200;

        public override object CreateDrawableObject()
        {
            var control = new RectangleControl();

            control.rect.Height = Height;
            control.rect.Width = Width;
            control.rect.Stroke = Stroke;
            control.rect.Fill = BackgroundColor;
            control.rect.StrokeThickness = StrokeThickness;

            return control;
        }
    }
}
