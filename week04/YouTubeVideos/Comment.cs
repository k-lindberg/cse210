public class Comment
{
    private string _userName;
    private string _commentText;

    public Comment(string userName, string commentText)
    {
        _userName = userName;
        _commentText = commentText;
    }

    public string GetDisplayText()
    {
        return $"{_userName}: {_commentText}";
    }
}