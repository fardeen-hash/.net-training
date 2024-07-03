using System;

public class Post
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime CreatedAt { get; private set; }
    private int _votes;

    public Post(string title, string description)
    {
        Title = title;
        Description = description;
        CreatedAt = DateTime.Now;
        _votes = 0;
    }

    public void UpVote()
    {
        _votes++;
    }

    public void DownVote()
    {
        _votes--;
    }

    public int GetVotes()
    {
        return _votes;
    }

    public void DisplayPost()
    {
        Console.WriteLine("Post Details:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Created At: {CreatedAt}");
        Console.WriteLine($"Current Vote Value: {GetVotes()}");
    }
}