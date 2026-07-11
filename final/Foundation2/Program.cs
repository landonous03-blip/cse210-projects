using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Bartholomew Jenkins", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-191", 25.50, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "MK-232", 79.99, 1));

        Address addr2 = new Address("476 Crown St", "Camas", "WA", "USA");
        Customer cust2 = new Customer("January Jabs", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("USB-C Hub", "UC-303", 45.00, 1));
        order2.AddProduct(new Product("Monitor Stand", "MS-768", 30.00, 2));
        order2.AddProduct(new Product("IMAX Webcam", "WC-395", 55.00, 1));

        List<Order> orders = new List<Order> { order1, order2 };
        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"=== ORDER #{orderNumber++} ===");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"TOTAL PRICE: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine(new string('=', 30) + "\n");
        }
    }
}