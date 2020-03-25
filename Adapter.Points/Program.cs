using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Adapter.Points
{
    class Point
    {
        public int X { get; set; }  
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }

    class VectorObject : Collection<Line>
    {
        
    }

    class Rectangle : VectorObject
    {
        public Rectangle(int x, int y, int width, int height)
        {
            Add(new Line(new Point(x,y), new Point(x+width, y) ));
            Add(new Line(new Point(x+width,y), new Point(x+width, y+height) ));
            Add(new Line(new Point(x,y), new Point(x, y+height) ));
            Add(new Line(new Point(x,y+height), new Point(x+width, y+height) ));
        }
    }

    class LineToPointAdapter : List<Point>
    {
        private static int count = 0;
        public LineToPointAdapter(Line line)
        {
            Console.WriteLine($"{++count}: Generating points for line [{line.Start.X},{line.Start.Y}]-[{line.End.X},{line.End.Y}]");
            //X coordinate is drawn left -> right
            int left = Math.Min(line.Start.X, line.End.X);
            int right = Math.Max(line.Start.X, line.End.X);
            //Y coordinate is drawn top -> bottom
            int top = Math.Min(line.Start.Y, line.End.Y);
            int bottom = Math.Max(line.Start.Y, line.End.Y);

            int dx = right - left;
            int dy = line.End.Y - line.Start.Y;

            if (dx == 0)
            {
                for (int y = top; y <= bottom; ++y)
                {
                    Add(new Point(left, y));
                }
            } else if (dy == 0)
            {
                for (int x = left; x <= right; ++x)
                {
                    Add(new Point(x, top));
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Draw();
        }
        private static void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }
        // the interface we have
        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }
        private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
        {
            new Rectangle(1, 1, 10, 10),//square
            new Rectangle(3, 3, 6, 6)//square
        };
    }
}
