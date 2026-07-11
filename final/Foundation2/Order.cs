using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> lb_products = new List<Product>();
    private Customer lb_customer;

    public Order(Customer customer)
    {
        lb_customer = customer;
    }

    public void AddProduct(Product product)
    {
        lb_products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in lb_products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost = lb_customer.LiveInUSA() ? 5.00 : 35.00;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder("PACKING LABEL:\n");
        foreach (Product product in lb_products)
        {
            label.AppendLine($" - {product.GetName()} (ID: {product.GetProductId()})");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{lb_customer.GetName()}\n{lb_customer.GetAddress().GetFullAddress()}\n";
    }
}