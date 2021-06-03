using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;

    }

    public class Operations
    {
        public static List<Product> Products => new List<Product>()
        {
            new Product() {Id = 1, Name = "Orange"},
            new Product() {Id = 2, Name = "Apple"},
            new Product() {Id = 3, Name = "Grape"}
        };

        public static List<Product> ProductsWithSelect()
        {
            var products = Products;
            products.Insert(0, new Product() { Id = -1, Name = "Select" });

            return products;
        }
    }
}
