public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, double points) : base(name, description, points)
    {
    
    }

    public override double RecordEvent()
    {
        return lb_points; // Returns the points so they can be added up
    }

    public override bool IsComplete()
    {
        return false; // Can't fully complete an eternal goal
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{lb_shortname},{lb_description},{lb_points}";
    }
}