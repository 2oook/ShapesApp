using ShapesApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public PointCollection Points { get; set; } = new PointCollection();
    }
}
