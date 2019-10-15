using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Polymorphism
{
    class RectangularPyramid : Box
    {
        public RectangularPyramid(double Lenght, double Width, double Height) : base(Lenght, Width, Height)
        {
            //all parameters passed to the base class Box:
        }
        public override double Volume()
        {
            return (Lenght * Width * Height) / 3d;
        }
        public override double Area()
        {
            double surfaceAreaOfRectPermad = Lenght * Width + .5 * Width * Math.Sqrt(Math.Pow((4 * Height), 2) + Math.Pow(Lenght, 2)) + (.5 * Lenght) * Math.Sqrt(Math.Pow(4 * Height, 2) + Math.Pow(Width, 2));
            return surfaceAreaOfRectPermad;
        }
        public override double Perimeter()
        {
            //surface area = (1 / 2 * base perimeter* slant height) +base area
            double primeterOfBase = 2 * (Lenght + Width);
            double areaOfBase = Lenght * Width;
            //Pythagorean theorem is used to calculate the slant hight.
            double slentHeightSquared = (Math.Pow(Height, 2)) + (Math.Pow(Lenght / 2, 2));
            double slentHeight = Math.Sqrt(slentHeightSquared);
            double surfaceArea = (.5 * primeterOfBase * slentHeight) + areaOfBase;
            return surfaceArea;
        }
    }
}
