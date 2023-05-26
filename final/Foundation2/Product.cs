using System;

namespace ProductOrderingSystem
{
    public class Product
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, string id, decimal price, int quantity)
        {
            Name = name;
            Id = id;
            Price = price;
            Quantity = quantity;
        }

    }
}