public class Assignment
{
    private string lb_studentName;
    private string lb_topic;

    public Assignment(string studentName, string topic)
    {
        lb_studentName = studentName;
        lb_topic = topic;
    }

    public string GetStudentName()
    {
        return lb_studentName;
    }

    public string GetTopic()
    {
        return lb_topic;
    }

    public string GetSummary()
    {
        return lb_studentName + " - " + lb_topic;
    }
}