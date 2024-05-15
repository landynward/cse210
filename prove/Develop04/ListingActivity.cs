class ListingActivity : Activity
{
    private static readonly string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        AnimateSpinner(3);
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("List an item: ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
    }
}