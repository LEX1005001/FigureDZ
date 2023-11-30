using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassLibary
{
    public class Trapezoid : Shape
    {
        public Trapezoid(List<Point> points) : base(points)
        {
        }

        public override double getSquare()
        {
            double AD = Math.Sqrt(Math.Pow(points[0].X - points[3].X, 2) + Math.Pow(points[0].Y - points[3].Y, 2));
            double BC = Math.Sqrt(Math.Pow(points[1].X - points[2].X, 2) + Math.Pow(points[1].Y - points[2].Y, 2));
            double AB= Math.Sqrt(Math.Pow(points[1].X - points[2].X, 2) + Math.Pow(points[1].Y - points[2].Y, 2));

        }
    }
}
