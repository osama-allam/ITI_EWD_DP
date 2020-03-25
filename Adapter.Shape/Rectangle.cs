using System;

namespace Adapter.Shape
{
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public void Resize()
        {
            Console.WriteLine("Resizing Rectangle");
        }

        public String Description()
        {
            return "Rectangle object";
        }

        public bool IsHide()
        {
            return false;
        }
    }
}