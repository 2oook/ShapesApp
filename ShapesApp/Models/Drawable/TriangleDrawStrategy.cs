using ShapesApp.Controls;
using ShapesApp.Models.Drawable.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp.Models.Drawable
{
    public class TriangleDrawStrategy : ITriangleDrawStrategy
    {
        public object CreateDrawableTriangle(Triangle triangle)
        {
            var control = new TriangleControl();

            control.triangle.Points = triangle.Points;
            control.triangle.Stroke = triangle.Stroke;
            control.triangle.Fill = triangle.BackgroundColor;
            control.triangle.StrokeThickness = triangle.StrokeThickness;

            return control;
        }
    }
}
