using System;

class Program
{
    static void Main(string[] args)
    {

        //EXCEEDING REQUIREMENTS:
        //I added a session log that keeps track of which activities the user has done and how many.
        string choice = "";

        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (choice != "4")
        {
            Console.WriteLine("-Menu Options-");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();

                breathingCount++;
            }

            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();

                reflectingCount++;
            }

            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();

                listingCount++;
            }

            else if (choice == "4")
            {
                Console.WriteLine("Well done! Here is your session summary:");
                Console.WriteLine($"Breathing Activities: {breathingCount}");
                Console.WriteLine($"Reflecting Activities: {reflectingCount}");
                Console.WriteLine($"Listing Activities: {listingCount}");
                Console.WriteLine("\nGoodbye!");
            }

            else
            {
                Console.WriteLine("That is not a valid option. Please try again.");
            }

            Console.WriteLine();
        }
    }
}