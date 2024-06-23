using System;

namespace ShapeNamespace
{
    class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw()
        {
            System.Console.WriteLine("Drwaing shape...");
        }
    }

    class Circle : Shape
    {
        public  void Draw()
        {
            System.Console.WriteLine("Drawing circle");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            System.Console.WriteLine("Drawing rectangle");
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing triangle");
        }
    }
}
