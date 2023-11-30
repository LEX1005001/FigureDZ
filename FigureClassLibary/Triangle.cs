using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassLibary
{
    public class Triangle : Shape
    {
        

        public Triangle(List<Point> points) : base(points)
        {
            
        }

        public override double getSquare()
        {
            double firstSide = Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2)+ Math.Pow(points[0].Y - points[1].Y, 2));
            double secondSide = Math.Sqrt(Math.Pow(points[1].X - points[2].X,2) + Math.Pow(points[1].Y - points[2].Y,2));
            double thirdSide= Math.Sqrt(Math.Pow(points[2].X - points[0].X, 2) + Math.Pow(points[2].Y - points[0].Y, 2));

            double p = (firstSide + secondSide + thirdSide) / 2;//Полупериметр

            return Math.Sqrt(p*(p-firstSide)*(p-secondSide)*(p-thirdSide));

        }

    }
}
