using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video vid1 = new Video("C# Basics in 10 Minutes", "CodeMaster", 600);
        vid1.AddComment(new Comment("Allison", "Great explanation of classes!"));
        vid1.AddComment(new Comment("Rob", "This helped me pass my exam, thanks!"));
        vid1.AddComment(new Comment("Charleston", "Can you do a video on interfaces next?"));
        videos.Add(vid1);

        Video vid2 = new Video("Top 10 Programming Languages 2026", "TechGuru", 850);
        vid2.AddComment(new Comment("David", "C# should definitely be #1!"));
        vid2.AddComment(new Comment("Evelyn", "Python is way easier for beginners though."));
        vid2.AddComment(new Comment("Francis", "Awesome list! Very informative!"));
        videos.Add(vid2);

        Video vid3 = new Video("Object-Oriented Programming Explained", "DevEd", 1200);
        vid3.AddComment(new Comment("Grayson", "Polymorphism finally makes sense to me now!"));
        vid3.AddComment(new Comment("Hanz", "The diagrams were super helpful!"));
        vid3.AddComment(new Comment("Evan", "Best tutorial on YouTube!"));
        videos.Add(vid3);

        foreach (Video vid in videos)
        {
            Console.WriteLine($"Title: {vid.Title}");
            Console.WriteLine($"Author: {vid.Author}");
            Console.WriteLine($"Length: {vid.LengthInSeconds}");
            Console.WriteLine($"Number of Comments: {vid.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in vid.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: \"{comment.Text}\"");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}