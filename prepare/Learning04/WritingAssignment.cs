public class WritingAssignment : Assignment
{
    private string lb_title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        lb_title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{lb_title} by {studentName}";
    }
}