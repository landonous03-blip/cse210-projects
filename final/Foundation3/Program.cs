using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("100 University Ave", "Rexburg", "ID", "USA");
        Event lecture = new Lecture("AI in 2026", "A dive into modern web agents and LLMs.", "Oct 15, 2025", "2:00 PM", addr1, "Dr. Alan Turing", 150);

        Address addr2 = new Address("500 Grand Hotel Way", "Salt Lake City", "UT", "USA");
        Event reception = new Reception("Tech Networking Gala", "Meet professionals across the industry.", "Nov 1, 2038", "6:30 PM", addr2, "rsvp@techgala.com");

        Address addr3 = new Address("300 Park Blvd", "Vancouver", "WA", "USA");
        Event outdoor = new OutdoorGathering("Summer Coding BBQ", "Food, Games, and Outdoor Coding Challenges!", "July 20, 2130", "12:00 PM", addr3, "Sunny, 85°F with a light breeze");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("--- STANDARD DETAILS ---");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("\n--- FULL DETAILS ---");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("\n--- SHORT DESCRIPTION ---");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine(new string('=', 40) + "\n");
        }
    }
}