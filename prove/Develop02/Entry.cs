public class Entry
{
    public string lb_date;
    public string lb_promptText;
    public string lb_entryText;

    public string lb_mood;

    public void Display()
    {
        Console.WriteLine($"Date: {lb_date} - Mood: {lb_mood}");
        Console.WriteLine($"Prompt: {lb_promptText}");
        Console.WriteLine(lb_entryText);
        Console.WriteLine();
    }
}