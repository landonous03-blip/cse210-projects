public class Running : Activity
{
    private double lb_distance; //in miles

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        lb_distance = distance;
    }

    public override double GetDistance() => lb_distance;
    public override double GetSpeed() => (lb_distance / GetMinutes()) * 60;
    public override double GetPace() => GetMinutes() / lb_distance;
}