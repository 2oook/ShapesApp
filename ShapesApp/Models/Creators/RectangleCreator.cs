using ShapesApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp.Models.Creators
{
    /// <summary>
    /// Класс создателя прямоугольников
    /// </summary>
    class RectangleCreator : ShapeCreator
    {
        /// <summary>
        /// Метод для создания прямоугольника
        /// </summary>
        /// <returns>Объект прямоугольника</returns>
        public override Shape CreateShape(IDrawStrategy drawStrategy)
        {
            return new Rectangle(drawStrategy);
        }
    }
}
