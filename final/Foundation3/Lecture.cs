public class Lecture : Event
{
    private string lb_speaker;
    private int lb_capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        lb_speaker = speaker;
        lb_capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Lecture\nSpeaker: {lb_speaker}\nCapacity: {lb_capacity} attendees";
    }
}