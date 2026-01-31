using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>()
        {
            new Product("Labubu", "P001", 45.00m, 1),
            new Product("Lego", "P002", 60.50m, 2),
            new Product("Pokemon Plush", "P003", 20.99m, 3)
        };

        Address address1 = new Address("50 Hello Kitty Ave.", "Anaheim", "CA", "USA");

        Customer customer1 = new Customer("Adalynn", address1);

        Order order1 = new Order(products1, customer1);

        Console.WriteLine($"Packing label: \n{order1.PackingLabel()}");
        Console.WriteLine($"Shipping Label: \n{order1.ShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.TotalPrice().ToString("F2")}");
        Console.WriteLine();

        List<Product> products2 = new List<Product>()
        {
            new Product("Collar", "P004", 15.00m, 1),
            new Product("Treat", "P005", 5.50m, 2),
            new Product("Toy", "P006", 8.99m, 3)
        };

        Address address2 = new Address("123 Jimmy John Dr.", "Sandwich", "Kent", "England");

        Customer customer2 = new Customer("Minnie", address2);

        Order order2 = new Order(products2, customer2);

        Console.WriteLine($"Packing label: \n{order2.PackingLabel()}");
        Console.WriteLine($"Shipping Label: \n{order2.ShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.TotalPrice().ToString("F2")}");
    }
}