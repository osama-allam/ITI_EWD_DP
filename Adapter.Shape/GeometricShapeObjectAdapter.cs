using System;

namespace Adapter.Shape
{
    public class GeometricShapeObjectAdapter : Shape
    {
        private GeometricShape adaptee;

        public GeometricShapeObjectAdapter(GeometricShape adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Draw()
        {
            adaptee.DrawShape();
        }

        public void Resize()
        {
            Console.WriteLine(Description() + " can't be resized. Please create new one with required values.");
        }

        public String Description()
        {
            if (adaptee is Triangle)
            {
                return "Triangle object";
            }
            else if (adaptee is Rhombus)
            {
                return "Rhombus object";
            }
            else
            {
                return "Unknown object";
            }
        }

        public bool IsHide()
        {
            return false;
        }
    }
}