using ShapesApp.Controls;
using ShapesApp.Models.Drawable.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp.Models.Drawable
{
    public class RectangleDrawStrategy : IRectangleDrawStrategy
    {
        public object CreateDrawableRectangle(Rectangle rectangle)
        {
            var control = new RectangleControl();

            control.rect.Height = rectangle.Height;
            control.rect.Width = rectangle.Width;
            control.rect.Stroke = rectangle.Stroke;
            control.rect.Fill = rectangle.BackgroundColor;
            control.rect.StrokeThickness = rectangle.StrokeThickness;

            return control;
        }
    }
}
