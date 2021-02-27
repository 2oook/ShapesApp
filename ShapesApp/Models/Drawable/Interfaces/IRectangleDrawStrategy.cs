using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp.Models.Drawable.Interfaces
{
    public interface IRectangleDrawStrategy
    {
        object CreateDrawableRectangle(Rectangle rectangle);
    }
}
