using System;
using System.Collections.Generic;
using Coding.Exercise;
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

            foreach( string task in tasks.GetTasks())
            {
                System.Console.WriteLine(task);
            }
        }
        static void Main(string[] args)
        {
            /*GENERIC LIST*/
            genericList();
            System.Console.WriteLine("\n-------------------------------\n");
            TaskExercise();
        }

    }

}