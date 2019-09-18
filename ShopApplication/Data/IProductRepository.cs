using ShopApplication.Data.Entities;
using ShopApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data
{
    public interface IProductRepository
    {
        Product[] GetAllProducts();
        Product GetProductById(int id);
        void Delete(Product model);
        void Add(Product product);
        bool SaveChanges();
    }
}
