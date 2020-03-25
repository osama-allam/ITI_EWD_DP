using System;

namespace Adapter.Shape
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Creating drawing of shapes...");
            //Drawing drawing1 = new Drawing();
            //drawing1.AddShape(new Rectangle());
            //drawing1.AddShape(new Circle());
            //Console.WriteLine("Drawing...");
            //drawing1.draw();
            //Console.WriteLine("Resizing...");
            //drawing1.Resize();

            Console.WriteLine("Creating drawing of shapes...");
            Drawing drawing2 = new Drawing(); //Client
            drawing2.AddShape(new Rectangle());
            drawing2.AddShape(new Circle());
            drawing2.AddShape(new GeometricShapeObjectAdapter(new Triangle()));
            drawing2.AddShape(new GeometricShapeObjectAdapter(new Rhombus()));
            Console.WriteLine("Drawing...");
            drawing2.draw();
            Console.WriteLine("Resizing...");
            drawing2.Resize();
        }
    }
}