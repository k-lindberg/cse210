using Microsoft.VisualBasic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public int NumberOfComments()
    {
        return _comments.Count;
    }
    
    public string GetDisplayText()
    {
        string videoInfo = $"{_title} by {_author}, {_length} seconds.\n";
        videoInfo += $"Comments ({_comments.Count}): \n";

        foreach (Comment comment in _comments)
        {
            videoInfo += $"- {comment.GetDisplayText()}\n";
        }

        return videoInfo;
    }
}