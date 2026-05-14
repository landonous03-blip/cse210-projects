using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator myPrompts = new PromptGenerator();

        string userChoice = "";

        //To exceed the requirements, I made it where the program asks the user for their mood, and records that in the journal entry as well.

        while (userChoice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string prompt = myPrompts.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("> ");
                string response = Console.ReadLine();

                Console.WriteLine("What is your current mood? ");
                string mood = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                myJournal.AddEntry(newEntry);
            }

            else if (userChoice == "2")
            {
                myJournal.DisplayAll();
            }

            else if (userChoice == "3")
            {
                Console.Write("What is the name of the file you want to load? ");
                string fileName = Console.ReadLine();

                myJournal.LoadFromFile(fileName);
            }

            else if (userChoice == "4")
            {
                Console.Write("What would you like to name your file? ");
                string fileName = Console.ReadLine();

                myJournal.SaveToFile(fileName);
            }

            else if (userChoice == "5")
            {
                break;
            }

        }
    }
}