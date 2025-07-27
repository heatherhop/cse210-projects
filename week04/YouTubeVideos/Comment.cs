public class Comment
{
    private string _commentAuthor;
    private string _commentText;
    public Comment(string author, string text)
    {
        _commentAuthor = author;
        _commentText = text;
    }
    public void DisplayCommentInfo()
    {
        Console.WriteLine($"Comment Author: {_commentAuthor}");
        Console.WriteLine($"Comment Text: {_commentText}");
    }

}