using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("01 Aj Str", "Lagos", "LAG", "NGN");
        Address address2 = new Address("10 Broadway Str", "New York", "NY", "USA");

        Customer customer1 = new Customer("Emma Ama", address1);
        Customer customer2 = new Customer("Jon Bellion", address2);

        Product product1 = new Product("Laptop", 1001, 999.99m, 1);
        Product product2 = new Product("Headphones", 1002, 49.99m, 2);
        Product product3 = new Product("Mouse", 1003, 19.99m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Price: ${order.TotalCost():0.00}");
            Console.WriteLine("========================================\n");
        }
    }
}