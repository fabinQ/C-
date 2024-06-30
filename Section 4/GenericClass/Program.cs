using System;
using System.Collections.Generic;
using Coding.Exercise;
using PersonClass;
using System.Linq;
using System.Reflection.Metadata;

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



        }

    }

}