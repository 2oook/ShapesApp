using ShapesApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp.Models
{
    /// <summary>
    /// Базовый класс фигур
    /// </summary>
    class Shape
    {
        public IDrawStrategy DrawStrategy { get; set; }
    }
}
