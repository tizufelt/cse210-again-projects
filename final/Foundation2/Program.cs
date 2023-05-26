using System;
using System.Collections.Generic;

namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some products
            Product product1 = new Product("Cisco Certified DevNet Associate - Offical Cert Guide", "DEVASC 200-901", 49.99m, 1);
            Product product2 = new Product("Cisco Certified Network Associate - Offical Cert Guide", "CCNA 200-301", 39.99m, 5);
            Product product3 = new Product("CCNP and CCIE Enterprise Core - Official Cert Guide", "ENCOR 350-401", 47.99m, 2);

            // Create a customer
            Address address = new Address("698 Candlewood Lane", "Cabot Cove", "Maine", "USA");
            Customer customer = new Customer("Jessica Fletcher", address);

            // Create an order
            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            Order order = new Order(customer, products);

            // Output the packing label and shipping label
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + order.GetTotalCost().ToString("0.00"));
        }
    }
}