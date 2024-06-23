using System;

namespace Coding.Exercise
{
    public interface IShape
    {
        // Deklaracja metod w interfejsie bez parametrów.
        double CalculateArea();
        double CalculatePerimeter();
    }

    public class Square : IShape
    {
        // Implementacja klasy Square z metodami interfejsu.
        public double valueShape { get; set; }

        public Square(double valueShape)
        {
            this.valueShape = valueShape;
        }

        public double CalculateArea()
        {
            return valueShape * valueShape;
        }

        public double CalculatePerimeter()
        {
            return 4 * valueShape;
        }
    }

    public class Circle : IShape
    {
        // Implementacja klasy Circle z metodami interfejsu.
        public double valueShape { get; set; }

        public Circle(double valueShape)
        {
            this.valueShape = valueShape;
        }

        public double CalculateArea()
        {
            return Math.PI * valueShape * valueShape;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * valueShape;
        }
    }
}
