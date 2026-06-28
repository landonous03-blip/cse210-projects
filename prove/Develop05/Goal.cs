public abstract class Goal
{
    protected string lb_shortname;
    protected string lb_description;
    protected double lb_points;

    // Unpacking the protected strings
    public Goal(string shortname, string description, double points)
    {
        lb_shortname = shortname;
        lb_description = description;
        lb_points = points;
    }

    public abstract double RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string check = IsComplete() ? "X" : " ";
        return $"[{check}] {lb_shortname} ({lb_description})";
    }

    public abstract string GetStringRepresentation();
}