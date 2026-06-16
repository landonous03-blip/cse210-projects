using System;
public class Circle : Shape
{
    private double lb_radius;

    public Circle(string color, double radius) : base(color)
    {
        lb_radius = radius;
    }

    public override double GetArea()
    {
        double exactArea = Math.PI * (lb_radius * lb_radius);

        return Math.Round(exactArea, 2);
    }
}