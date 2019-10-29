using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_29_Part
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Length = 5;
            rect1.Width = 10;

            //p1 is the defined name for perimeter
            double p1 = rect1.CalculatePerimeter();
                                          
            Console.WriteLine($"Rectangle 1 with {rect1.Length} length and {rect1.Width} width has a perimiter of {p1} and an area of {rect1.CalculateArea()}");

            Rectangle rect2 = new Rectangle();
            rect2.Length = 200;
            rect2.Width = 5;

            Console.WriteLine($"Rectangle 2 with {rect2.Length} length and {rect2.Width} width has a perimiter of {rect2.CalculatePerimeter()} and an area of {rect2.CalculateArea()}");

            //for the circle
            Circle circ1 = new Circle();
            circ1.radius = 4;

            double per = circ1.CalculateCircPerimeter();
            double area = circ1.CalculateCircArea();

            Circle circ2 = new Circle();
            circ2.radius = 62;

            double per2 = circ2.CalculateCircPerimeter();
            double area2 = circ2.CalculateCircArea();

            Console.WriteLine($"Circle 1 with {circ1.radius} radius has a perimiter of {per.ToString("N2")} and an area of {area.ToString("N2")}" );
            Console.WriteLine($"Circle 2 with {circ2.radius} radius has a perimiter of {per2.ToString("N2")} and an area of {area2.ToString("N2")}");


            Console.ReadKey();
        }
    }
}
