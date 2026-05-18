using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Console.WriteLine("---");

        Fraction f5 = new Fraction();
        f5.SetTop(2);
        f5.SetBottom(5);
        Console.WriteLine($"Fraction 5: string: {f5.GetFractionString()} Number: {f5.GetDecimalValue()}");

        Fraction randomFraction = new Fraction();

        Random rng = new Random();

        Console.WriteLine("\n--- Random Fractions ---");

        for (int i = 1; i <= 20; i++)
        {
            int topNum = rng.Next(1, 11);

            int bottomNum = rng.Next(1, 11);

            randomFraction.SetTop(topNum);

            randomFraction.SetBottom(bottomNum);

            Console.WriteLine($"Fraction: {i}: string: {randomFraction.GetFractionString()} Number: {randomFraction.GetDecimalValue()}");
            
        }
    }
}