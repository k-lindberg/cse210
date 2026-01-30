using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> ytVideo = new List<Video>();

        Video video1 = new Video("Is there a God? | A Journey to Faith and Light", "The Church of Jesus Christ of Latter-Day Saints", 313);

        video1.AddComment(new Comment("Minnie", "Love this!"));
        video1.AddComment(new Comment("Jasper", "Great video."));
        video1.AddComment(new Comment("Elise", "Thank you for posting!"));
        video1.AddComment(new Comment("Hayden", "I needed this."));

        ytVideo.Add(video1);

        Video video2 = new Video("Greater Love | Easter 2025", "The Church of Jesus Christ of Latter-Day Saints", 89);

        video2.AddComment(new Comment("Mike", "Nice visuals."));
        video2.AddComment(new Comment("Gavin", "Happy Easter!"));
        video2.AddComment(new Comment("Derek", "I love the music!"));
        video2.AddComment(new Comment("Lisa", "Very inspiring."));

        ytVideo.Add(video2);

        Video video3 = new Video("Welcome to the Church of Joy", "The Church of Jesus Christ of Latter-Day Saints", 94);

        video3.AddComment(new Comment("Cecil", "I love this church!"));
        video3.AddComment(new Comment("Mandi", "Truely Joyful."));
        video3.AddComment(new Comment("Darrin", "Couldn't agree more."));
        video3.AddComment(new Comment("Adalynn", "Amazing message!"));

        ytVideo.Add(video3);

        Video video4 = new Video("How Jesus Christ Restores What Is Broken", "The Church of Jesus Christ of Latter-Day Saints", 213);

        video4.AddComment(new Comment("Larrie", "Perfect timing."));
        video4.AddComment(new Comment("Sherry", "Love this message."));
        video4.AddComment(new Comment("Edna", "Jesus Christ is my Savior."));
        video4.AddComment(new Comment("Elwood", "I will share this message!"));

        ytVideo.Add(video4);

        foreach (Video video in ytVideo)
        {
            Console.WriteLine(video.GetDisplayText());

            Console.WriteLine();
        }
    }
}