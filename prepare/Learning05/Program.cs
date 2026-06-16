using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square block = new Square("Blue", 3.0);
        shapes.Add(block);

        Rectangle stinker = new Rectangle("Red", 5.0, 3.0);
        shapes.Add(stinker);

        Circle poof = new Circle("Yellow", 3.0);
        shapes.Add(poof);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}