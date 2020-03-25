using System;

namespace Adapter.Shape
{
    // Part of Extra-Geometric-Shape API
    public class Rhombus : GeometricShape
    {

        // sides
        private double a;
        private double b;

        public Rhombus() : this(1.0d, 1.0d)
        {
        }

        public Rhombus(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Area()
        {
            double s = a * b;
            return s;
        }

        public double Perimeter()
        {
            return 2 * (a + b);
        }

        public void DrawShape()
        {
            Console.WriteLine("Drawing Rhombus with area: " + Area() + " and perimeter: " + Perimeter());
        }
    }
}