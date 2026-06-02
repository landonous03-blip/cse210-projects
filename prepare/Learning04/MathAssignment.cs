public class MathAssignment : Assignment
{
    private string lb_textbookSection;
    private string lb_problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        lb_textbookSection = textbookSection;
        lb_problems = problems;
    }

    public string GetHomeworkList()
{
    return $"Section {lb_textbookSection} Problems {lb_problems}";
}
}