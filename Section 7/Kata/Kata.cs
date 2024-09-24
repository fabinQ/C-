using System;

namespace Kata;

public class Kata
{
    //"this is a test" -> "test a is this"
    // 1. "this is a test" -> ["this", "is", "a", "test"]
    // 2. ["this", "is", "a", "test"] -> ["test", "a", "is", "this"]

    public static List<string> Split(string input, char separator)
    {
        List<string> result = new List<string>();
        int currentIndex = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if(input[i] == separator)
            {
                string word = input.Substring(currentIndex, i - currentIndex);
                result.Add(word);
                currentIndex = i+1;
            }
            else if(i == input.Length-1)
            {
                string word = input.Substring(currentIndex, input.Length-currentIndex);
                result.Add(word);
            }
        }
        return result;
    }
    public static string ReverseWords(string str)
    {
        

        System.Console.WriteLine("New string");
        string [] newString = str.Split();
        System.Console.WriteLine(newString);
        return "";
    }
    string returnString = Kata.ReverseWords("Dupa Jaś, jesteś dupa.");
}
