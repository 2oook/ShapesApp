using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp.Models.Creators
{
    /// <summary>
    /// Базовый класс создателей форм
    /// </summary>
    abstract class ShapeCreator
    {
        /// <summary>
        /// Метод для создания формы
        /// </summary>
        /// <returns>Объект формы</returns>
        public abstract Shape CreateShape(double x, double y);
    }
}
