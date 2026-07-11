public class Address
{
    private string lb_street;
    private string lb_city;
    private string lb_state;
    private string lb_country;

    public Address(string street, string city, string state, string country)
    {
        lb_street = street;
        lb_city = city;
        lb_state = state;
        lb_country = country;
    }

    public string GetAddressString()
    {
        return $"{lb_street}, {lb_city}, {lb_state}, {lb_country}";
    }
}