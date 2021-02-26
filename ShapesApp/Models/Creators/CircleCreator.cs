using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp.Models.Creators
{
    /// <summary>
    /// Класс создателя окружностей
    /// </summary>
    class CircleCreator : ShapeCreator
    {
        /// <summary>
        /// Метод для создания окружности
        /// </summary>
        /// <returns>Объект окружности</returns>
        public override Shape CreateShape()
        {
            return new Circle();
        }
    }
}
