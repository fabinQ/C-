using System;

namespace Coding.Exercise
{
    public interface ICalculatorAreasAndPerimeters
    {
        // Deklaracja metod w interfejsie bez parametrów.
        double CalculateArea();
        double CalculatePerimeter();
    }

    public class SquareCalculate : ICalculatorAreasAndPerimeters
    {
        // Implementacja klasy Square z metodami interfejsu.
        public double valueShape { get; set; }

        public SquareCalculate(double valueShape)
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

    public class CircleCalculate : ICalculatorAreasAndPerimeters
    {
        // Implementacja klasy Circle z metodami interfejsu.
        public double valueShape { get; set; }

        public CircleCalculate(double valueShape)
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
