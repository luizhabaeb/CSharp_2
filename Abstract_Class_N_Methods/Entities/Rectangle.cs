using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Class_N_Methods.Entities.ENUMs;

namespace Abstract_Class_N_Methods.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }

        public double Height { get; set; }


        public Rectangle(double width, double height, Color color)
        : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

    }
}
