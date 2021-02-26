using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp.Models.Interfaces
{
    /// <summary>
    /// Интерфейс стратегии отрисовки фигуры
    /// </summary>
    public interface IDrawStrategy
    {
        void Draw();
    }
}
