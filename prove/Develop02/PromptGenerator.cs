public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
      "Who was the most interesting person I ran into today?",
      "What was the best part of my day?",
      "How did I see the Lord's hand in my life today?",
      "If I could redo just one thing today, what would it be?",
      "What am I going to do differently because of today?"  
    };
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
}