using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Hide and Seek!");

        
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.";

        
        Scripture scripture = new Scripture(reference, text);

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetHiddenText());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            if (Console.ReadLine().ToLower() == "quit")
                break;

            scripture.HideRandomWord();
        }

        Console.WriteLine("Program ended. Press any key to exit.");
        Console.ReadKey();
    }
}