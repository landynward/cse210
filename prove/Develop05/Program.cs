using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class Program
{
    private static GoalManager goalManager = new GoalManager();

    static void Main()
    {
        string userInput = string.Empty;

        while (userInput != "6")
        {
            // Display user's score
            Console.WriteLine($"Score: {GoalManager.UserScore}");

            // Display menu options
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    goalManager.CreateNewGoal();
                    break;
                case "2":
                    goalManager.ListGoals();
                    break;
                case "3":
                    goalManager.SaveGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    goalManager.SaveGoals();
                    Console.WriteLine("Goodbye!");
                    break;
            }
        }
    }
}