using System;
using System.Collections.Generic;
using System.Linq;

namespace Fluent_Interface_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Mause",Price=3000},
                new Product{Id=2,Name="Keybord",Price=5000},
                new Product{Id=3,Name="Manitore",Price=10000},
            };

            var Contains = products.Where(p => p.Name.Contains("K"));
            var order = Contains.OrderByDescending(p=> p.Id);
            var select = order.Select(p=> new {p.Name});

            var result = products.Where(p => p.Name.Contains("K"))
                .OrderByDescending(p => p.Id)
                .Select(p => new { p.Name });

            ProductService productService = new ProductService();
            productService.Id(10).Name("LapTop").Price(25000).Print();

            Console.ReadLine();
        }
    }

    public class ProductService
    {
        private Product _product = new Product();

        public ProductService Id(long Id)
        {
            _product.Id = Id;
            return this;
        }

        public ProductService Name(string Name)
        {
            _product.Name= Name;
            return this;
        }

        public ProductService Price(int Price)
        {
            _product.Price = Price;
            return this;
        }

        public void Print()
        {
            Console.WriteLine($"ID = {_product.Id} | NAME = {_product.Name} | PRICE = {_product.Price}");
        }
    }
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
