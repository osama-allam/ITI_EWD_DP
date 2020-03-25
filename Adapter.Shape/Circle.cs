using System;

namespace Adapter.Shape
{
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }

        public void Resize()
        {
            Console.WriteLine("Resizing Circle");
        }

        public String Description()
        {
            return "Circle object";
        }

        public bool IsHide()
        {
            return false;
        }
    }
}