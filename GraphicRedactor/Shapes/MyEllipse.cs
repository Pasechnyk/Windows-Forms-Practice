using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Shapes
{
    internal class MyEllipse : IShape
    {
        //public Pen Pen { get; set; }
        public Brush Brush { get; set; }
        public Rectangle Rectangle { get; set; }

        public MyEllipse(Color color, Point location, Size size)
        {
            //Pen = new Pen(Color.Black, 4);
            Brush = new SolidBrush(color);
            Rectangle = new Rectangle(location.X, location.Y, size.Width, size.Height);
        }

        public void Print(Graphics graphics)
        {
            graphics.FillEllipse(Brush, Rectangle);
        }
    }
}
