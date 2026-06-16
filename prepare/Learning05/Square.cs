using System.Diagnostics.Contracts;

public class Square : Shape
{
    private double lb_side;

    public Square(string color, double side) : base(color)
    {
        lb_side = side;
    }

    public override double GetArea()
    {
        return lb_side * lb_side;
    }
}