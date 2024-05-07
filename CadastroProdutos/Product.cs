using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProdutos
{
    internal class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(int id, string description, double price, int quantity)
        {
            Id = id;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public override string? ToString()
        {
            return $"{Id};{Description};{Price};{Quantity}";
        }
    }
}
