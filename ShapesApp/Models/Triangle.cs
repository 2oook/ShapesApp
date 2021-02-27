using ShapesApp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace ShapesApp.Models
{
    /// <summary>
    /// Класс представляющий треугольник
    /// </summary>
    class Triangle : Shape
    {
        /// <summary>
        /// Коллекция точек описывающих форму треугольника
        /// </summary>
        public PointCollection Points { get; set; } = new PointCollection() 
        {
            new Point(){ X = 50, Y = 0 },
            new Point(){ X = 0, Y = 100 },
            new Point(){ X = 100, Y = 100 },
            new Point(){ X = 50, Y = 0 },
        };

        public override object CreateDrawableObject()
        {
            var control = new TriangleControl();

            control.triangle.Points = Points;
            control.triangle.Stroke = Stroke;
            control.triangle.Fill = BackgroundColor;
            control.triangle.StrokeThickness = StrokeThickness;

            return control;
        }
    }
}
