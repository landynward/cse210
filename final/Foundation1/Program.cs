using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Python Tutorial", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Nice explanation."));

        Video video2 = new Video("Cooking Pasta", "Jane Smith", 300);
        video2.AddComment(new Comment("Dave", "Yummy!"));
        video2.AddComment(new Comment("Eva", "I will try this recipe."));

        Video video3 = new Video("Travel Vlog: Japan", "Emily Rose", 1200);
        video3.AddComment(new Comment("Frank", "Amazing footage!"));
        video3.AddComment(new Comment("Grace", "I want to visit Japan now!"));
        video3.AddComment(new Comment("Hank", "Great vlog, very informative."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine(video);
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  - {comment}");
            }
            Console.WriteLine();
        }
    }
}
