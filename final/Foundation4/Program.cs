using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2023, 6, 1), 30, 3.0),
            new Cycling(new DateTime(2023, 6, 2), 45, 15.0),
            new Swimming(new DateTime(2023, 6, 3), 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
