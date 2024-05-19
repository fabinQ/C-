using System;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        /// <summary>
        /// main method description
        /// </summary>
        /// <param name="args">args description</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your name");
            // string name = Console.ReadLine();
            // Console.WriteLine("Witaj " + name);

            char jChar = 'j';
            char jCharUnicode = '\u006A';

            bool isUserReady = false;

            DateTime now = new DateTime(1999,09,09);
            Console.WriteLine(now);

            byte byteNumber = 200;
            float floatNumber = 1.5f;
            decimal decimalNumber = 1.5m;
            double doubleNumber = 1.5;
            Console.WriteLine(byteNumber);
            Console.WriteLine(floatNumber);
            Console.WriteLine(decimalNumber);
            Console.WriteLine(doubleNumber);

            string message1;
            message1 = "Ciag char.";
            string message2 = "Znak \" oraz \\ w tekscie";
            Console.WriteLine(message2);
            string message3 = @"c:\windows\fonts";
            Console.WriteLine(message3);

            string message4 = null;
            string message5 = string.Empty;
            Console.WriteLine(message5.GetType);

            string concatenatedString = string.Concat(message1, message2, "!");
            string concatenatedString2 = message1 + message2 + "!";

            string interpolatedString = $"{message1} {message2} !";
            Console.WriteLine(interpolatedString);
            // Nadpisywanie stringów zajmuje pamięć jesli będziemy cos rozszerzać to lepiej użyć StringBuilder

            StringBuilder sb = new StringBuilder("This is string builder.");
            sb.Append(" Można go rozszerzyć!");
            sb.Append(" Wiele razy.");
            Console.WriteLine(sb);

            string result = sb.ToString();
            Console.WriteLine(result);


            int value1 =10;
            int value2 =10;
            Console.WriteLine(++value1);
            Console.WriteLine(value2++);
            Console.WriteLine(value2);

            bool boolResult;
            int x=3;
            int y=10;

            boolResult = (x == y);
            Console.WriteLine("Equal to Operator: (x==y) = "+ boolResult);

            // Operator warunkowy, skrócona wersja if else
            // zmienna = warunek ? Jeśli tak : Jeśli nie;
            int greaterNumber = x>y ? x:y;
            Console.WriteLine("Ternary conditional operator: x>y ? x : y = "+greaterNumber);
            
            
            // Komentarze
            static void Program2(string[] args){
                Console.WriteLine();
                int value= (2+2)*5; //20;
                /*
                Komentarz blokowy 
                */
            }
        }
    }
}