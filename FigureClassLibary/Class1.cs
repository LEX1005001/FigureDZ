using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassLibary
{
    public class Сircle : Shape
    {

        public Сircle(List<Point> points) : base(points)
        {
        }

        public override double getSquare()
        {
           double R = Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2) + Math.Pow(points[0].Y - points[1].Y,2));
            return 2 * Math.PI * R;
        }
    }
}
