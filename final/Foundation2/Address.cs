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

    public bool IsInUSA()
    {
        return lb_country.Trim().Equals("USA", StringComparison.OrdinalIgnoreCase) || lb_country.Trim().Equals("United States", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{lb_street}\n{lb_city}, {lb_state}\n{lb_country}";
    }
}