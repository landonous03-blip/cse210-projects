public class ListingActivity : Activity
{
    private int lb_count;
    private List<string> lb_prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userResponses = GetListFromUser();
        lb_count = userResponses.Count;

        Console.WriteLine($"You listed {lb_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(lb_prompts.Count);

        return lb_prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(lb_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                userList.Add(item);
            }
        }
        return userList;
    }

}