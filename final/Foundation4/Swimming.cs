public class Swimming : Activity
{
    private int lb_laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        lb_laps = laps;
    }

    public override double GetDistance()
    {
        return lb_laps * 50.0 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}