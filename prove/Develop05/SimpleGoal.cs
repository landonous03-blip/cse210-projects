public class SimpleGoal : Goal
{
    private bool lb_isComplete;

    public SimpleGoal(string name, string description, double points) : base(name, description, points)
    {
        lb_isComplete = false;
    }

    public SimpleGoal(string name, string description, double points, bool isComplete) : base(name, description, points)
    {
        lb_isComplete = isComplete;
    }

    public override double RecordEvent()
    {
        lb_isComplete = true;
        return lb_points; // Returns the points so they can be added up
    }

    public override bool IsComplete()
    {
        return lb_isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{lb_shortname},{lb_description},{lb_points},{lb_isComplete}";
    }
}