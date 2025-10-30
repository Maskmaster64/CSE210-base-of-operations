public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string Title, string StudentName, string Topic) : base(StudentName, Topic)
    {
        _title = Title;
    }

    public void GetWritingInfo()
    {
        GetSummary();
        Console.WriteLine($"{_title}");
    }
}