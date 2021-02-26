using ShapesApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp.Models.Creators
{
    /// <summary>
    /// Класс создателя треугольников
    /// </summary>
    class TriangleCreator : ShapeCreator
    {
        /// <summary>
        /// Метод для создания треугольника
        /// </summary>
        /// <returns>Объект треугольника</returns>
        public override Shape CreateShape(IDrawStrategy drawStrategy)
        {
            return new Triangle(drawStrategy);
        }
    }
}
