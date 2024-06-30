using System;
using System.Collections.Generic;
using Coding.Exercise;
using PersonClass;
using System.Linq;
using System.Reflection.Metadata;
using CurrencyClass;
using Coding.Exercise.GradeManagerClass;
using System.Runtime.InteropServices;

namespace GenericClass
{
    internal class Program
    {
        static void DisplayElements(List<int> ListToDisplay)
        {
            foreach (int element in ListToDisplay)
            {
                System.Console.Write($"{element},");
            }
            System.Console.WriteLine("");

        }
        static void DisplayEmployees(List<Person> ListToDisplay)
        {
            foreach (Person element in ListToDisplay)
            {
                System.Console.Write($"{element.FirstName},");
            }
            System.Console.WriteLine("");

        }
        static void genericList()
        {
            List<int> intList = new List<int>() { 6, 1, 0, 100, 3, 5, 101, -1 };
            intList.Add(0);
            DisplayElements(intList);
            intList.Add(2);
            DisplayElements(intList);

            // Remove
            System.Console.WriteLine("Remove Range.");
            intList.RemoveRange(1, 2);
            DisplayElements(intList);

            // Sort
            System.Console.WriteLine("Sorting");
            intList.Sort();
            DisplayElements(intList);

        }
        static void TaskExercise()
        {
            TaskManager tasks = new TaskManager();
            tasks.AddTask("Do first!");
            tasks.AddTask("Do secound!");
            tasks.AddTask("Do third!");

            tasks.RemoveTask("Do first!");
            tasks.RemoveTask("Do ");

            foreach (string task in tasks.GetTasks())
            {
                System.Console.WriteLine(task);
            }
        }
        static List<Person> GetEmployees()
        {
            List<Person> employees = new List<Person>
            {
                new Person(new DateTime(1990, 2, 2), "Bill", "Wick"),
                new Person(new DateTime(1995, 6, 3), "John", "Wick"),
                new Person(new DateTime(1996, 4, 3), "Bob", "Wick"),
                new Person(new DateTime(2001, 2, 2), "Bill", "Smith"),
                new Person(new DateTime(2000, 2, 2), "John", "Smith"),
                new Person(new DateTime(2005, 2, 2), "Bob", "Smith"),
                new Person(new DateTime(2003, 2, 2), "Ed", "Smith"),
            };
            return employees;
        }
        static List<Person> SortedEmployees(List<Person> employees)
        /*LINQ
        LAMBDA */
        {
            List<Person> sortedEmployees = employees.Where(e => e.GetDateOfBirth() > new DateTime(2000, 1, 1)).ToList();

            return sortedEmployees;
        }
        static void SayHiBob(List<Person> sortedEmplyees)
        /*LINQ*/
        {
            bool EmployeeIsBob(Person employee)
            {
                return employee.FirstName == "Bob";
            }
            Person bob = sortedEmplyees.FirstOrDefault(EmployeeIsBob);

            if (bob != null)
            {
                bob.SayHi();
            }
            else
            {
                System.Console.WriteLine("Bob not found!");
            }
        }
        public static Dictionary<string, Currency> GetCurrencies()
        {
            return new Dictionary<string, Currency>
            {
                {"USD", new Currency("USD", "United Stated Dollar", 1.0)},
                {"EUR", new Currency("EUR", "Euro", 0.83975)},
                {"GBP", new Currency("GBP", "British Pound", 0.74771)},
                {"CAD", new Currency("CAD", "Canadian Dollar", 1.30725)},
                {"INR", new Currency("INR", "Indian Rupe", 73)},
                {"MXN", new Currency("MXN", "Mexican Peso", 25.7175)},
                
            };
        }
        public static void GradeManager()
        {
            GradeManager dicOfPerson = new GradeManager();
            dicOfPerson.AddGrade("John", 3);
            dicOfPerson.AddGrade("John", 5);
            dicOfPerson.AddGrade("John", 1);
            dicOfPerson.AddGrade("Matt", 1);
            dicOfPerson.AddGrade("Matt", 4);
            dicOfPerson.AddGrade("Matt", 4);

            dicOfPerson.RemoveGrade("John",1);
            dicOfPerson.RemoveGrade("Matt",1);
            dicOfPerson.RemoveGrade("Johnny",1);
            dicOfPerson.RemoveGrade("Matthew",1);
            
            Console.WriteLine($"John average grade is {dicOfPerson.CalculateAverageGrade("John")}");
            Console.WriteLine($"Matt average grade is {dicOfPerson.CalculateAverageGrade("Matt")}");
            Console.WriteLine($"Johnny average grade is {dicOfPerson.CalculateAverageGrade("Johnny")}");
            Console.WriteLine($"Matthe average grade is {dicOfPerson.CalculateAverageGrade("Matthew")}");
        }

        public static IEnumerable<int> GetYieldData()
        {
            for (int i =0; i<9; i++)
            {
                yield return i;
            }

        }
        public static IEnumerable<int> GenerateEvenNumbers()
        {
            int i = 0;
            while (true)
            {
                yield return i;
                i+=2;
            }
        }

        static void Main(string[] args)
        {
            /*GENERIC LIST*/
            genericList();
            System.Console.WriteLine("\n-------------------------------\n");
            TaskExercise();
            System.Console.WriteLine("\n-------------------------------\n");

            List<Person> employees = GetEmployees();


            /*LINQ*/
            List<Person> sortedEmployees = SortedEmployees(employees);
            DisplayEmployees(sortedEmployees);
            System.Console.WriteLine($"Young emploees count: {sortedEmployees.Count}");
            SayHiBob(sortedEmployees);

            System.Console.WriteLine("\n-------------------------------\n");
            
            /*Currency, dictionary */
            Dictionary<string,Currency> currencies = GetCurrencies();
            System.Console.WriteLine("Check the rate for: ");
            // string userInput = Console.ReadLine().ToUpper();
            string userInput = "USD";
            Currency selectedCurrency = null;
            if (currencies.TryGetValue(userInput, out selectedCurrency))
            {
                System.Console.WriteLine($"Rate for USD to {userInput} is {selectedCurrency.Rate}");
            }
            else
            {
                System.Console.WriteLine("Currency not found");
            }

            System.Console.WriteLine("\n-------------------------------\n");

            /* GradeManager */
            GradeManager();

            System.Console.WriteLine("\n-------------------------------\n");

            /* YIELD */
            foreach (int i in GetYieldData())
            {
                System.Console.WriteLine(i);
            }
            
            // GetYieldData().ToList().ForEach(i => System.Console.WriteLine(i));

            System.Console.WriteLine("\n-------------------------------\n");
            
            foreach (int i in GenerateEvenNumbers())
            {
                System.Console.WriteLine(i);
                if (i==8)
                {
                    break;
                }
            }
        }

    }

}