using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopApplication.Data.Entities;
using ShopApplication.Models;

namespace ShopApplication.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly MarketContext _context;

        public ProductRepository(MarketContext context)
        {
            this._context = context;
        }

        public void Add(Product product)
        {
            _context.Add(product);
        }

        public void Delete(Product product)
        {
            _context.Remove(product);
        }

        public Product[] GetAllProducts()
        {
            IQueryable<Product> query = _context.Products
                .Include(c => c.Group);
            return query.ToArray();
        }

        public Product GetProductById(int id)
        {
            IQueryable<Product> query = _context.Products
                .Include(c => c.Group);
            query = query.Where(q => q.ProductId == id);
            return query.FirstOrDefault();
        }

        public bool SaveChanges()
        {
           return _context.SaveChanges()>0;
        }
    }
}
