using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Rectangle
    {
            public double Length { get; set; }
            public double Width { get; set; }

            // Expression-bodied properties
            public double Area => Length * Width;

            // Expression-bodied method
            public double GetArea() => Length * Width;

            // NEW: Perimeter (expression-bodied)
            public double GetPerimeter() => 2 * (Length + Width);
        }

    }

