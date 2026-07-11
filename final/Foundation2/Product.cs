public class Product
{
    private string lb_name;
    private string lb_productId;
    private double lb_pricePerUnit;
    private int lb_quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        lb_name = name;
        lb_productId = productId;
        lb_pricePerUnit = pricePerUnit;
        lb_quantity = quantity;
    }

    public string GetName() => lb_name;
    public string GetProductId() => lb_productId;
    public double GetTotalCost() => lb_pricePerUnit * lb_quantity;
}