using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Polymorphism
{
    public class Rectangle
    {
        private readonly double _length;
        private readonly double _width;
        public Rectangle(double Lenght, double Width)
        {
            _length = Lenght;
            _width = Width;
        }

        public virtual double Lenght
        {
            get { return _length; }
        }
        public virtual double Width
        {
            get { return _width; }
        }
        public virtual double Height
        {
            get { return 0; }
        }

        public virtual double Perimeter()
        {
            return 2 * (Lenght + Width);
        }
        public virtual double Area()
        {

            return Lenght * Width;
        }
        public virtual double Volume()
        {
            return 0;
        }
    }
}
