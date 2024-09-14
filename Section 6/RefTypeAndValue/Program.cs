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
        ////////////////////////////////////////////////////////////////

        int result;
        string input;
        System.Console.WriteLine("\nInsert negative number.");
        while(!TryParseToNegative ("-1", out result)) //System.Console.ReadLine()
        {
            System.Console.WriteLine("\nInsert negative number.");
        }
        System.Console.WriteLine($"Negative value: {result}");
        ////////////////////////////////////////////////////////////////
        int horsePower1= 350;
        int horsePower2= 350;
        bool valueTypeEquality = horsePower1 == horsePower2;

        Car car1 = new Car(horsePower1);
        Car car2 = new Car(horsePower2);
        bool referenceTypeEquality = car1.Equals(car2);
        bool referenceTypeEquality2 = car1 == car2;

        System.Console.WriteLine($"Value Type Equality {valueTypeEquality}");
        System.Console.WriteLine($"Reference Type Equality {referenceTypeEquality}");
        System.Console.WriteLine($"== {referenceTypeEquality2}");
        ////////////////////////////////////////////////////////////////
        

    }
    public class ApiClient
    {
        private string baseUrl = "https://our-api-dev.com";
        private const string getUserEndpoint = "/api/clients";
        private HttpClient httpClient = new HttpClient();
        private int defaultPort = 80;

        public void GetUsers()
        {
            var getUserUri = $"{baseUrl}{getUserEndpoint}";
            httpClient.GetAsync(getUserUri);

        }

        public void PostUsers()
        {

        }

        public void GetResources()
        {
            
        }
    }

internal class GetResources
{
}

public class Car
    {
        public static bool operator ==(Car left, Car right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(Car left, Car right)
        {
            return !Equals(left, right);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            Car carObj = (Car)obj;
            return this.HorsePower == carObj.HorsePower;
        }
        public Car (int horsePower)
        {
            HorsePower = horsePower;
        }
        public int HorsePower{get;set;}
    }
}
