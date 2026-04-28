using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        int guessCount = 0;

        while (true)
        {

            guessCount++;

            if (guess < number)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("You guessed it!");
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You guessed the word in {guessCount} tries!");

    }
}