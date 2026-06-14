using System.Threading;

public class Activity
{
    protected string lb_name;
    protected string lb_description;
    protected int lb_duration;

    public Activity(string name, string description)
    {
        lb_name = name;
        lb_description = description;

    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {lb_name}!");

        Console.WriteLine();

        Console.WriteLine(lb_description);

        Console.WriteLine();

        Console.Write("How long, in seconds, would you like your session to be?");

        string userInput = Console.ReadLine();

        lb_duration = int.Parse(userInput);

        Console.Clear();

        Console.WriteLine("Get ready...");

        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
       Console.WriteLine();
       Console.WriteLine("Well done!");
       ShowSpinner(3);

       Console.WriteLine();
       Console.WriteLine($"You have completed another {lb_duration} seconds of {lb_name}!");
       ShowSpinner(5); 
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            if (i >= 10)
            {
                Console.Write("\b\b \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
        }
    }
}