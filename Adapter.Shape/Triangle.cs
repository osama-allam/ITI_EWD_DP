using System;

namespace Adapter.Shape
{
    // Part of Extra-Geometric-Shape API
    public class Triangle : GeometricShape
    {

        // sides
        private double a;
        private double b;
        private double c;

        public Triangle() : this(1.0d, 1.0d, 1.0d)
        {
        }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Area()
        {
            // Heron's formula:
            // Area = SquareRoot(s * (s - a) * (s - b) * (s - c)) 
            // where s = (a + b + c) / 2, or 1/2 of the perimeter of the triangle 
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public double Perimeter()
        {
            // P = a + b + c
            return a + b + c;
        }

        public void DrawShape()
        {
            Console.WriteLine("Drawing Triangle with area: " + Area() + " and perimeter: " + Perimeter());
        }
    }
}