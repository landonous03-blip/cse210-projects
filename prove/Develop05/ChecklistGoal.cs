public class ChecklistGoal : Goal
{
    private int lb_amountCompleted;
    private int lb_target;
    private double lb_bonus;

    public ChecklistGoal(string name, string description, double points, int target, double bonus) : base(name, description, points)
    {
        // Initialize it to 0 because a new goal hasn't been completed yet
        lb_amountCompleted = 0;
        lb_target = target;
        lb_bonus = bonus;
    }

    public ChecklistGoal(string name, string description, double points, int target, double bonus, int amountCompleted) : base(name, description, points)
    {
        lb_target = target;
        lb_bonus = bonus;
        lb_amountCompleted = amountCompleted;
    }

    public override double RecordEvent()
    {
        lb_amountCompleted++;

        if (lb_amountCompleted == lb_target)
        {
            return lb_points + lb_bonus;
        }
        else
        {
            return lb_points;
        }
    }

    public override bool IsComplete()
    {
        return lb_amountCompleted >= lb_target;
    }

    public override string GetDetailsString()
    {
        string standardDetails = base.GetDetailsString();
        return $"{standardDetails} -- Completed {lb_amountCompleted}/{lb_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{lb_shortname},{lb_description},{lb_points},{lb_bonus},{lb_target},{lb_amountCompleted}";
    }
}