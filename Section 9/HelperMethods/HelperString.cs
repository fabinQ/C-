using System;
using System.Runtime.CompilerServices;

namespace HelperMethods;

public class HelperString
{
    public void helperMain()
    {
        System.Console.WriteLine("insert Input:");
        // string input = System.Console.ReadLine();
        string userInput = "Konstatynopolitańczykowianeczka";
        SubString(userInput);
        Replace(userInput);
        Modify(userInput);
        AlterTextCase(userInput);
        Split(userInput);
        CheckString(userInput );
    }

    static void SubString(string userInput)
    {
        if (userInput.Length > 10)
        {
            string startSubstring = userInput.Substring(0,10);
            string endSubstring = userInput.Substring(userInput.Length-10);
            System.Console.WriteLine($"{startSubstring}........{endSubstring}");
            System.Console.WriteLine(userInput);
            System.Console.WriteLine();
        }
    }
    static void Replace(string userInput )
    {
        string template = "Hello {name}, how are you?";
        string output = template.Replace("{name}", userInput);
        System.Console.WriteLine(output);
        System.Console.WriteLine();
    }
    
    static void Modify(string userInput )
    {
        string removeString = userInput.Remove(5);
        string subString = userInput.Substring(5);
        string insertString = userInput.Insert(5,"INSERT");
        string userInput2 = "       konstatyno poli tańczykowia neczka     ";
        string trimmedString = userInput2.Trim();

        System.Console.WriteLine(removeString);
        System.Console.WriteLine(subString);
        System.Console.WriteLine(insertString);
        System.Console.WriteLine(trimmedString);

        System.Console.WriteLine();
    }

    static void AlterTextCase(string userInput )
    {
        string upperCase = userInput.ToUpper();
        string lowerCase = userInput.ToLower();

        System.Console.WriteLine(upperCase);
        System.Console.WriteLine(lowerCase);

        System.Console.WriteLine();
    }
    static void Split(string userInput )
    {
        userInput = "Jan Kowalski";
        string[] inputParts = userInput.Split(" ");
        string firstName = inputParts[0];
        string lastName = inputParts[inputParts.Length -1];

        System.Console.WriteLine($@"Hello {firstName} {lastName}!");
        System.Console.WriteLine(string.Join(" ",inputParts));
        System.Console.WriteLine();
    }
    static void CheckString(string userInput )
    {
        userInput ="docFile.txt";
        bool isTextFile = userInput.EndsWith(".txt", StringComparison.CurrentCultureIgnoreCase);
        bool startWithDocPrefix = userInput.StartsWith("doc", StringComparison.CurrentCultureIgnoreCase);
        
        bool containsText = userInput.Contains("file", StringComparison.CurrentCultureIgnoreCase);

        System.Console.WriteLine($"isTextFile: {isTextFile}");
        System.Console.WriteLine($"startWithDocPrefix: {startWithDocPrefix}");
        System.Console.WriteLine($"containsText: {containsText}");
        System.Console.WriteLine();
    }
}
