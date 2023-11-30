using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassLibary
{
    public class Rectangle : Shape
    {
        public Rectangle(List<Point> points) : base(points)
        {
        }

        public override double getSquare()
        {
            double AB = Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2) + Math.Pow(points[0].Y - points[1].Y, 2));
            double BC= Math.Sqrt(Math.Pow(points[1].X - points[2].X, 2) + Math.Pow(points[1].Y - points[2].Y, 2));
            return AB * BC;
        }
    }
}
