using ShapesApp.Controls;
using ShapesApp.Models.Drawable.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp.Models.Drawable
{
    public class CircleDrawStrategy : ICircleDrawStrategy
    {
        public object CreateDrawableCircle(Circle circle)
        {
            var control = new CircleControl();

            control.circle.Height = circle.Height;
            control.circle.Width = circle.Width;
            control.circle.Stroke = circle.Stroke;
            control.circle.Fill = circle.BackgroundColor;
            control.circle.StrokeThickness = circle.StrokeThickness;

            return control;
        }
    }
}
