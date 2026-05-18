using System;
public class Fraction
{
    private int lb_top;
    private int lb_bottom;

    public Fraction()
    {
        lb_top = 1;
        lb_bottom = 1;
    }

    public Fraction(int top)
    {
        lb_top = top;

        lb_bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        lb_top = top;
        
        lb_bottom = bottom;
    }

    public int GetTop()
    {
        return lb_top;
    }

    public void SetTop(int top)
    {
        lb_top = top;
    }

    public int GetBottom()
    {
        return lb_bottom;
    }

    public void SetBottom(int bottom)
    {
        lb_bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{lb_top}/{lb_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)lb_top / (double)lb_bottom;
    }
}