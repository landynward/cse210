abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Starting {Name} Activity");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        AnimateSpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        AnimateSpinner(3);
    }

    public void RunActivity()
    {
        StartMessage();
        PerformActivity();
        EndMessage();
    }

    protected abstract void PerformActivity();

    protected void AnimateSpinner(int seconds)
    {
        string spinner = "|/-\\";
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int counter = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[counter % spinner.Length]);
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
        }
    }
}