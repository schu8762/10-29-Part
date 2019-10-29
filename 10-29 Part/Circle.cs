using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_29_Part
{
    class Circle
    {
        public double radius {get; set;}
        public double pi { get; set; }

        public Circle()
        {
            radius = 0;
            pi = 0;
        }

        public double CalculateCircArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculateCircPerimeter()
        {
            return 2 * Math.PI * radius;
        }
        




    }
}
