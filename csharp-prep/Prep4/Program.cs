using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        Console.Write("Enter number: ");
        
        int guess = int.Parse(Console.ReadLine());

        while (guess != 0)
        { 
            numbers.Add(guess);

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");
            
            guess = int.Parse(Console.ReadLine());

        }

        int sum = 0;

        int largestNumber = numbers[0];

        foreach (int number in numbers)
        {
            sum = sum + number;

            if (number >= largestNumber)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largestNumber}");


    }
}