public class Cycling : Activity
{
    private double lb_speed; //in mph

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        lb_speed = speed;
    }

    public override double GetDistance() => (lb_speed * GetMinutes()) / 60;
    public override double GetSpeed() => lb_speed;
    public override double GetPace() => 60 / lb_speed;
}