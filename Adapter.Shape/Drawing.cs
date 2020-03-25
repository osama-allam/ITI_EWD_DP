using System;
using System.Collections.Generic;
using System.Linq;

namespace Adapter.Shape
{
    public class Drawing
    {
        List<Shape> shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public List<Shape> GetShapes()
        {
            return new List<Shape>(shapes);
        }

        public void draw()
        {
            if (!shapes.Any())
            {
                Console.WriteLine("Nothing to draw!");
            }
            else
            {
                shapes.ForEach(shape => shape.Draw());
            }
        }

        public void Resize()
        {
            if (!shapes.Any())
            {
                Console.WriteLine("Nothing to resize!");
            }
            else
            {
                shapes.ForEach(shape => shape.Resize());
            }
        }
    }
}