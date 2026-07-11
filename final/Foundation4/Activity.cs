public abstract class Activity
{
    private string lb_date;
    private int lb_minutes;

    public Activity(string date, int minutes)
    {
        lb_date = date;
        lb_minutes = minutes;
    }

    public string GetDate() => lb_date;
    public int GetMinutes() => lb_minutes;

    //Abstract methods to be overridden in the derived classes
    public abstract double GetDistance(); //in miles
    public abstract double GetSpeed(); //in mph
    public abstract double GetPace(); //in min per mile

    public virtual string GetSummary()
    {
        return $"{lb_date} {this.GetType().Name} ({lb_minutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}