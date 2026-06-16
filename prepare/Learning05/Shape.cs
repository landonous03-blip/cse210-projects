public class Shape
{
    private string lb_color;

    public Shape(string color)
    {
        lb_color = color;
    }

    public string GetColor()
    {
        return lb_color;
    }

    public void SetColor(string color)
    {
        lb_color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}