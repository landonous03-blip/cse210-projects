public class Event
{
    private string lb_title;
    private string lb_description;
    private string lb_date;
    private string lb_time;
    private Address lb_address;

    public Event(string title, string description, string date, string time, Address address)
    {
        lb_title = title;
        lb_description = description;
        lb_date = date;
        lb_time = time;
        lb_address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {lb_title}\nDescription: {lb_description}\nDate: {lb_date} | Time: {lb_time}\nAddress: {lb_address.GetAddressString()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: {this.GetType().Name}\nTitle: {lb_title}\nDate: {lb_date}";
    }

    protected string GetTitle() => lb_title;
    protected string GetDate() => lb_date;
}