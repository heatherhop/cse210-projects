using System.Net.Security;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Video Length: {_length} seconds");
        Console.WriteLine($"Number of comments for this video: {GetNumberOfComments()}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayCommentInfo();
        }
        Console.WriteLine();
    }

}