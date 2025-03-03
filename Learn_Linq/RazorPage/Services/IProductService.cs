using RazorPage.Data;
using System.Collections.Generic;
using System.Linq;

namespace RazorPage.Services
{
    public interface IProductService
    {
        int Add(ProductDto product);
        int Delete(int Id);
        ProductDto Find(int Id);
        List<ProductDto> List();
        ProductDto Edit(ProductDto product);
        List<ProductDto> Search(string name);
    }

    public class ProductService : IProductService
    {
        private readonly DataBaseContext _context;

        public ProductService(DataBaseContext context)
        {
            _context = context;
        }

        public int Add(ProductDto product)
        {
            Models.Product entity= new Models.Product
            {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
            };
            _context.Products.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public int Delete(int Id)
        {
            _context.Products.Remove(new Models.Product
            {
                Id = Id
            });
            return _context.SaveChanges();
        }

        public ProductDto Edit(ProductDto product)
        {
            var entity =_context.Products.Find(product.Id);
            entity.Name = product.Name;
            entity.Price = product.Price;
            entity.Description = product.Description;
            _context.SaveChanges();
            return product;
        }

        public ProductDto Find(int Id)
        {
            var product = _context.Products.Find(Id);
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
            };
        }

        public List<ProductDto> List()
        {
            var products = _context.Products.OrderByDescending(p => p.Id)
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                }).ToList();
            return products;
        }

        public List<ProductDto> Search(string name)
        {
            var products = _context.Products
                .Where(p => p.Name.Contains(name))
                .OrderByDescending(p => p.Id)
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                }).ToList();
            return products;
        }
    }

    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
