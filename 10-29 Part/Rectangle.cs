using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_29_Part
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        //CalculateArea(length : int ) : Double if there were parameters
        public double CalculateArea()
        {
            double area = Length * Width;
            return area;
        }

                    
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }






    }
}
