using System.Collections.Generic; // Required to use List<T>

namespace YouTubeMonitoring
{
    // A class to represent a video
    public class Video
    {
        // Properties to store video title, author, and length (in seconds)
        public string Title { get; }
        public string Author { get; }
        public int Length { get; }


        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            comments = new List<Comment>();
        }


        // A List to store comments
        private List<Comment> comments = new List<Comment>();

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public List<Comment> GetComments()
        {
            return comments;
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }
    }
}