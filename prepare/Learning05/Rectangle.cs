public class Rectangle : Shape
{
    private double lb_length;
    private double lb_width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        lb_length = length;
        lb_width = width;
    }

    public override double GetArea()
    {
        return lb_length * lb_width;
    }
}