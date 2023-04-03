using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Shapes
{
    internal class MyPie : IShape
    {
        public Brush Brush { get; set; }
        public Rectangle Rectangle { get; set; }

        public MyPie(Color color, Point location, Size size)
        {
            Brush = new SolidBrush(color);
            Rectangle = new Rectangle(location.X, location.Y, size.Width, size.Height);
        }

        public void Print(Graphics graphics)
        {
            graphics.FillPie(Brush, Rectangle, 20, 35);
        }
    }
}
