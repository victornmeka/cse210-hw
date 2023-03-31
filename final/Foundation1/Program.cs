using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Embrace Adversity", "Joshua Cromley", 158);
        video1.AddComment(new Comment("keke", "Exactly what I needed at the moment"));
        video1.AddComment(new Comment("Noms", "Brings a new perspective to Challenges."));
        video1.AddComment(new Comment("Egbon", "This was insightful."));
        videos.Add(video1);

        Video video2 = new Video("5mins. easy to prep. egg fried rice", "Seonkyoung Longest", 387);
        video2.AddComment(new Comment("Kyle", "It looks so easy to prepare."));
        video2.AddComment(new Comment("Lila", "I'm definitely trying this."));
        video2.AddComment(new Comment("Fzbara", "Excellent cutlery handling!"));
        videos.Add(video2);

        Video video3 = new Video("The Perfect Push Up!", "Calisthenicmovement", 218);
        video3.AddComment(new Comment("Sam", "Best pushup tutorial ever!"));
        video3.AddComment(new Comment("Ohia", "Thanks for sharing."));
        video3.AddComment(new Comment("Irene", "I've been doing it wrong all along."));
        video3.AddComment(new Comment("Ife", "Insightful!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"   {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}