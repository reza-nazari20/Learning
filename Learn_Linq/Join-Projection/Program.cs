using System;
using System.Collections.Generic;
using System.Linq;

namespace Join_Projection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            {
                new Category { Id = 1, Name = "Mobile" },
                new Category { Id = 2, Name = "PC" },
            };

            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, CategoryId = 1, Name = "A34" },
                new Product { Id = 1, CategoryId = 1, Name = "Iphone 15" },
                new Product { Id = 1, CategoryId = 1, Name = "X3" },
                new Product { Id = 1, CategoryId = 2, Name = "RP 565 ep" },
                new Product { Id = 1, CategoryId = 2, Name = "L3" },
            };

            var datajoin = products.Join(categories, p => p.CategoryId, c => c.Id, (product, category) =>
            new
            {
                productId = product.Id,
                productName = product.Name,
                productCategory = category.Name
            });


            foreach (var item in datajoin)
            {
                Console.WriteLine($"{item.productName} -->  {item.productCategory}");
            }

            Console.WriteLine("------------------------------------------------------");

            var groupjoinResult = categories.GroupJoin(products, c => c.Id, p => p.CategoryId, (category, product) =>
            new
            {
                prod=product,
                cat=category,  
            });

            foreach(var item in groupjoinResult)
            {
                Console.WriteLine($"Name Category : {item.cat.Name}  | Sub Menu :");
                foreach (var p in item.prod)
                {
                    Console.WriteLine($"*{p.Name}");
                }

                Console.WriteLine("===============================");
            }

            Console.ReadLine();
        }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

    }
}
