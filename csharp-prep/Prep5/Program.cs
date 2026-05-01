using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNumber, birthYear);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please Enter Your Name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please Enter Your Favorite Number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("Please Enter The Year You Were Born: ");
            birthYear = int.Parse(Console.ReadLine());
            
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            
            return square;
        }

        static void DisplayResult(string name, int squaredNumber, int birthYear)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}!");
            Console.WriteLine($"{name}, you will turn {2026 - birthYear} this year!");
        }

    }
}