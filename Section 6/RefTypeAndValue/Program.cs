using System;

namespace RefTypeAndValue;

public class Program
{
    static bool IsDivisible(int value, int factor, out int reminder)
    {
        reminder = value % factor;
        
        return reminder == 0;
    }
    public static void Double(ref int value)
    {
        value = value *2;
        System.Console.WriteLine(value);
    }
    public static bool TryParseToNegative (string input, out int result)
    {
        if (int.TryParse(input, out result))
        {
            if (result<0)
            {
                return true;
            }
            else
            {
                result = default;
                return false;
            }
        }
        else
        {
            result = default;
            return false;
        }
    }
    static void Main(string[] args)
    {
        int someValue = 5;
        Double(ref someValue);  
        System.Console.WriteLine(someValue);

        int value = 5;
        int factor = 2;
        int reminder;
        if (IsDivisible(value, factor,out reminder))
        {
            System.Console.WriteLine($"{value} is divided by {factor}");
        }
        else
        {
            System.Console.WriteLine($"{value} is not divided by {factor}. Remider is {reminder}");
        }


        int result;
        string input;
        while(!TryParseToNegative (System.Console.ReadLine(), out result))
        {
            System.Console.WriteLine("\nInsert negative number.");
        }
        System.Console.WriteLine($"Negative value: {result}");
    }
}
