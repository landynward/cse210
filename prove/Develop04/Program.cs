using System;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[]
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };

        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            if (int.TryParse(choice, out int activityIndex) && activityIndex >= 1 && activityIndex <= 3)
            {
                activities[activityIndex - 1].RunActivity();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting the program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}