using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassLibary
{
    public abstract class Shape
    {
        protected List<Point> points;

        public Shape(List<Point> points)
        {
            this.Points = points;
        }

        public List<Point> Points { get => points; set => points = value; }

        public abstract double getSquare();
    }
}
