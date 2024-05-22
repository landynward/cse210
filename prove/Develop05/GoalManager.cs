using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class GoalManager
{
    public static int UserScore { get; set; }
    private List<Goal> Goals { get; set; } = new List<Goal>();

    public void CreateNewGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                Goals.Add(new SimpleGoal(description, points));
                break;
            case "2":
                Goals.Add(new EternalGoal(description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                Goals.Add(new ChecklistGoal(description, points, targetCount, bonusPoints));
                break;
        }
    }

    public void ListGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i}. {Goals[i].GetStatus()}");
        }
    }

    public void SaveGoals()
    {
        var data = new { Score = UserScore, Goals = Goals };
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("goals.json", json);
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.json"))
        {
            var json = File.ReadAllText("goals.json");
            var root = JsonSerializer.Deserialize<JsonElement>(json);

            if (root.TryGetProperty("Score", out JsonElement scoreElement) && scoreElement.ValueKind == JsonValueKind.Number)
            {
                UserScore = scoreElement.GetInt32();
            }
            else
            {
                Console.WriteLine("Score not found or invalid in JSON.");
                UserScore = 0; // Set default score if not found
            }

            if (root.TryGetProperty("Goals", out JsonElement goalsElement) && goalsElement.ValueKind == JsonValueKind.Array)
            {
                Goals.Clear(); // Clear existing goals before loading new ones
                foreach (var goalJson in goalsElement.EnumerateArray())
                {
                    var description = goalJson.GetProperty("Description").GetString();
                    var points = goalJson.GetProperty("Points").GetInt32();
                    var isCompleted = goalJson.TryGetProperty("IsCompleted", out JsonElement isCompletedElement) && isCompletedElement.GetBoolean();
                    var goal = new SimpleGoal(description, points);
                    goal.IsCompleted = isCompleted;
                    Goals.Add(goal);
                }
                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("Goals not found or invalid in JSON.");
            }
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }


    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal to record event: ");
        int goalIndex = int.Parse(Console.ReadLine());
        if (goalIndex >= 0 && goalIndex < Goals.Count)
        {
            Goals[goalIndex].RecordEvent();
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
}