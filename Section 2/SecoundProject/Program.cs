using System;
using System.Collections.Generic;

namespace Coding.Exetcise
{
    public class GradeCalculator
    {
        public static string CalculateGrade(double percentage)
        {
            if(percentage >=90 && percentage<=100)
            {
                return "A";
            }
            else if (percentage<90 && percentage>=80)
            {
                return "B";
            }
            else if (percentage<80 && percentage>=70)
            {
                return "C";
            }
            else if (percentage<70 && percentage>=60)
            {
                return "D";
            }
            else if (percentage<60 && percentage>=0)
            {
                return "F";
            }
            else{
                return "Nieproawidłowa wartość";
            }
        }
    }
     public class ParkingCalculator
    {
        public static double CalculateParkingFee(int hours)
        {
            double result = 0;
            switch (hours)
            {
                case 1:
                {
                    result+=5;
                    break;
                }
                default:
                    result+=3;
                    break;
            }

            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string result = GradeCalculator.CalculateGrade(80);
            Console.WriteLine(result); 
            
            double result2 = ParkingCalculator.CalculateParkingFee(3);
            System.Console.WriteLine(result2);
        }
    }
}