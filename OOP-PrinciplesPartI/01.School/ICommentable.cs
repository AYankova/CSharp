namespace _01.School
{
    public interface ICommentable
    {
        void AddComment(string comment);
        void RemoveCommentAtIndex(int index);
        string GetCommentAtIndex(int index);
        string GetAllComments();
    }
}
