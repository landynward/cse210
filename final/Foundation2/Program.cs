using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Vancouver", "BC", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Widget", "W123", 10.0, 3);
        Product product2 = new Product("Gadget", "G456", 15.0, 2);
        Product product3 = new Product("Doodad", "D789", 7.5, 5);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nOrder 1 Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nOrder 2 Total Cost: ${order2.GetTotalCost():F2}");
    }
}
