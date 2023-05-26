using System;
using System.Collections.Generic;

namespace YouTubeMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create 3-4 videos and add comments
            Video video1 = new Video("What is Automation", "Cisco DevNet", 960);
            video1.AddComment(new Comment("Verlaine_devnet", "insightful conversation,it changes my perspective "));
            video1.AddComment(new Comment("Ahmed", "Thanks for sharing!"));
            video1.AddComment(new Comment("JimmyG", "I learned a lot from this video."));
            videos.Add(video1);

            Video video2 = new Video("4 Things to Know About Cisco's DevNet Associate (200-901) Exam", "Kevin Wallace Training, LLC", 1280);
            video2.AddComment(new Comment("Szabolcs Cseres", "Another awesome video Kevin"));
            video2.AddComment(new Comment("V U", "You always rock Kevin.. Age is just a number sir"));
            videos.Add(video2);

            Video video3 = new Video("Cisco Certification Blueprints: Your Path to Decoding Exam Questions", "Cisco U. by Learning and Certifications", 540);
            video3.AddComment(new Comment("Jlopez", "appreciate the tips."));
            video3.AddComment(new Comment("FJohnson", "Good tips."));
            video3.AddComment(new Comment("KIskander", "Excellent!"));
            videos.Add(video3);

            // Iterate through the list of videos and display information
            foreach (var video in videos)
            {
                Console.WriteLine("Title: " + video.Title);
                Console.WriteLine("Author: " + video.Author);
                Console.WriteLine("Length (in seconds): " + video.Length);
                Console.WriteLine("Number of comments: " + video.GetNumberOfComments());

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine("Comment by " + comment.Name + ": " + comment.Text);
                }

                Console.WriteLine();
            }
        }
    }
}