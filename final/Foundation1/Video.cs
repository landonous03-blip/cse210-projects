using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> lb_comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        lb_comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return lb_comments.Count;
    }

    public List<Comment> GetComments()
    {
        return lb_comments;
    }
}