using FigureClassLibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(new List<Point>() { new Point(0,0),new Point(0,3),new Point(4,0)});
            Сircle circle = new Сircle(new List<Point>() { new Point(0, 0), new Point(0, 3) });
            Console.WriteLine("Площадь треугольника"+triangle.getSquare());
            Console.WriteLine("Площадь круга"+circle.getSquare());

            Console.ReadKey();
        }
    }
}
