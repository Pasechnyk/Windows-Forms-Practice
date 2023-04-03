using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Shapes
{
    public interface IShape
    {
        void Print(Graphics graphics);
    }
}
