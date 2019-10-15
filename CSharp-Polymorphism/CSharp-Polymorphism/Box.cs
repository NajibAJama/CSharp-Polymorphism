using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Polymorphism
{
    public class Box : Rectangle
    {
        private readonly double _height;
        public Box(double Lenght, double Width, double Height) : base(Lenght, Width)
        {
            _height = Height;
        }
        public override double Height
        {
            get { return _height; }
        }

        public override double Area()
        {
            return 2 * (Height * Width) + 2 * (Height * Lenght) + 2 * (Width * Lenght);
        }
        public override double Volume()
        {
            return Lenght * Width * Height;
        }
        public override double Perimeter()
        {
            return 2 * (Lenght + Width);
        }
    }
}
