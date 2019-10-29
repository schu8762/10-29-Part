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


            Console.ReadKey();
        }
    }
}
