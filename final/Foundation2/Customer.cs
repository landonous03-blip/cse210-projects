public class Customer
{
    private string lb_name;
    private Address lb_address;

    public Customer(string name, Address address)
    {
        lb_name = name;
        lb_address = address;
    }

    public string GetName() => lb_name;
    public Address GetAddress() => lb_address;
    public bool LiveInUSA() => lb_address.IsInUSA();
}