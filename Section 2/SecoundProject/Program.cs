using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading;
using SecoundProject;

namespace Coding.Exetcise
{
    public class GradeCalculator
    {
        public static string CalculateGrade(double percentage)
        {
            if (percentage >= 90 && percentage <= 100)
            {
                return "A";
            }
            else if (percentage < 90 && percentage >= 80)
            {
                return "B";
            }
            else if (percentage < 80 && percentage >= 70)
            {
                return "C";
            }
            else if (percentage < 70 && percentage >= 60)
            {
                return "D";
            }
            else if (percentage < 60 && percentage >= 0)
            {
                return "F";
            }
            else
            {
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
                        result += 5;
                        break;
                    }
                default:
                    result += 5 + (hours - 1) * 3;
                    break;
            }
            return result;
        }
    }
  public class TemperatureAnalyzer
    {
        // Znajduje najwyższą temperaturę w tablicy temperatur
        public static int FindHighestTemperature(int[] temperatures)
        {
            int temp_max = temperatures[0];
            foreach (int temp in temperatures)
            {
                if (temp_max<temp)
                {
                    temp_max = temp;
                }
            }
            return temp_max;
        }
    
        // Znajduje najniższą temperaturę w tablicy temperatur
        public static int FindLowestTemperature(int[] temperatures)
        {
            int temp_min = temperatures[0];
            foreach (int temp in temperatures)
            {
                if (temp_min>temp)
                {
                    temp_min = temp;
                }
            }
            return temp_min;
        }
    }
    class Program
    {
        static void PrasePhrase()
        {
            byte byteValue = 100;
            int intValue = byteValue;
            byte byteValue2 = (byte)intValue;
            double doubleValue = 4.5;
            int intValue2 = (int)doubleValue;
            System.Console.WriteLine(intValue2);

            string stringValue2 = intValue2.ToString();


            System.Console.WriteLine("Write your year of birth");
            string userInput = Console.ReadLine();
            int yearOfBirth;
            if (int.TryParse(userInput, out yearOfBirth))
            {
                int age = DateTime.Now.Year - yearOfBirth;
                Console.WriteLine("You are " + age);
            }
            else
            {
                System.Console.WriteLine("Incoret value");
                PrasePhrase();
            }
        }
        static void BMIindex()
        {
            System.Console.Write("BMI index ");
            System.Console.Write("Write your weight [kg]: ");

            string userInput = Console.ReadLine();
            float weight;
            if (float.TryParse(userInput, out weight))
            {
                System.Console.Write("Write your height [m]: ");
                string userInput2 = Console.ReadLine();

                float height;
                if (float.TryParse(userInput2, out height))
                {
                    float BMI = weight / (height * height);

                    Console.WriteLine("Your BMI " + BMI);
                    switch (BMI)
                    {
                        case < (float)18.5:
                            {
                                System.Console.WriteLine("UNDERWEIGHT");
                                break;
                            }
                        case < (float)24.9:
                            {
                                System.Console.WriteLine("NORMAL");
                                break;
                            }
                        case < (float)29.9:
                            {
                                System.Console.WriteLine("OVERWEIGHT");
                                break;
                            }
                        case < (float)34.9999:
                            {
                                System.Console.WriteLine("OBSESE");
                                break;
                            }
                        default:
                            {
                                System.Console.WriteLine("EXTREMELY OBSESE");
                                break;
                            }
                    }
                }
                else
                {
                    System.Console.WriteLine("Incorrect value. Try again");
                    BMIindex();
                }
            }
            else
            {
                System.Console.WriteLine("Incoret value. Try again");
                BMIindex();
            }
        }

        static void tableFunction()
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };
            System.Console.WriteLine(cars[0]);
            int arrayLength = cars.Length;
            System.Console.WriteLine("Length array " + arrayLength);
            cars[2] = "Tesla";
            System.Console.WriteLine(cars[2]);
        }
        static void whileFunction()
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };

            int i = 0;
            while (i <= (cars.Length - 1))
            {
                System.Console.WriteLine(cars[i]);
                if (cars[i] == "BMW")
                {
                    System.Console.WriteLine("Break");
                    break;
                }
                i++;
                System.Console.WriteLine("-----------------");
            }
        }
        static void doWhileFunction()
        {
            System.Console.WriteLine("To exit, tap 'x'");
            string userInput3;
            do
            {
                userInput3 = Console.ReadLine();
                System.Console.WriteLine($"Ech: {userInput3}");
            } while (userInput3 != "x");

        }
        static void forLoop()
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                System.Console.WriteLine(cars[i]);
                if (cars[i] == "BMW")
                {
                    System.Console.WriteLine("Break");
                    break;
                }
            }
        }
  static void forEachLoop()
        {
            string[] cars = {"Volvo", "BMW", "Mazda"};

            foreach(string car in cars)
            {
                System.Console.WriteLine(car);
                if (car == "BMW")
                {
                    System.Console.WriteLine("Bye");
                    break;
                }
            }
        }

        static void doWhlieZero()
        {
            int sum = 0;
            int max_number = int.MinValue;
            int userInput4;
            do{
                System.Console.WriteLine("Insert value. Insert 0 to exit.");
                userInput4 = int.Parse(Console.ReadLine());

                sum += userInput4;
                if (userInput4>max_number)
                {
                    max_number = userInput4;
                }
            }while(userInput4 !=0);
            System.Console.WriteLine($"Sum of numbers {sum}");
            System.Console.WriteLine($"Max number {max_number}");
        }

        
        static void userGender()
        {
            System.Console.WriteLine("What is your gernder? 1-Male 2-Famale");
            string userInput5 = System.Console.ReadLine();
            Gender userGenderInput = (Gender)Enum.Parse(typeof(Gender), userInput5);
            System.Console.WriteLine(userGenderInput);
         
            if (userGenderInput == Gender.Male)
            {
                System.Console.WriteLine("Only Famale are allow.");
            }
            else
            {
                System.Console.WriteLine("Hi");
            }
        }

        static void nullableIntValue()
        {
            // Do Inta nie możemy przypisać null
            int userValue = default;
            bool userHasValue = true;

            // Trójskładnikowy operator (bool? JeśliTrue : JeśliFalse)
            System.Console.WriteLine($"Toja liczba to {(userHasValue ? userValue.ToString() : "")}.");

            // Takie rozwiązanie powoduje zainicjowanie kolejnej zmiennej. C# ma specjalny typ nullable
            // Nullable może przechowywyać wszytskie wartości bazowe oraz wartuść null.

            // Nullable<int> userValue2 = null;
            int? userValue2 = null;

            // System.Console.WriteLine($"Toja liczba to {(userValue2 != null ? userValue2 : "")}.");
            System.Console.WriteLine($"Toja liczba to {(userValue2.HasValue ? userValue2 : "")}.");

        }
        static void TryCatchFunction()
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };

            try
            {
                int a = 19;
                // _ = a / 0;

                cars[4] = "Tersla";
            }
            catch (IndexOutOfRangeException e)
            {
                System.Console.WriteLine("Poza rangem.");
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine("Cholero nie dziel przez zero.");
            }
            finally
            {
                System.Console.WriteLine("Robi zawsze.");
            }
        }

        static void Main(string[] args)
        {
            // string result = GradeCalculator.CalculateGrade(80);
            // Console.WriteLine(result); 

            // double result2 = ParkingCalculator.CalculateParkingFee(3);
            // System.Console.WriteLine(result2);

            // PrasePhrase();

            // BMIindex();

            // tableFunction();

            // whileFunction();
            // doWhileFunction();
            // forLoop();
            // forEachLoop();
             
            // int [] temperatures = {-2,-20,3,32,-22,31};
            // System.Console.WriteLine(TemperatureAnalyzer.FindHighestTemperature(temperatures));
            // System.Console.WriteLine(TemperatureAnalyzer.FindLowestTemperature(temperatures));
            
            // doWhlieZero();

            // userGender();

            // nullableIntValue();

            TryCatchFunction();
        }
    }
}