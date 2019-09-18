using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopApplication.Data.Entities;

namespace ShopApplication.Data
{
    public class SaleRepository : ISaleRepository
    {
        private readonly MarketContext _context;

        public SaleRepository(MarketContext context)
        {
            this._context = context;
        }

        public object Include { get; private set; }

        public void Add(Sale sale)
        {
            _context.Add(sale);
        }

        public void Delete(Sale sale)
        {
            _context.Remove(sale);
        }

        public Sale[] GetAllSales()
        {
            IQueryable<Sale> query = _context.Sales
                .Include(q => q.Group)
                .Include(q => q.Product);
            return query.ToArray();

        }

        public Sale GetSaleById(int id)
        {
           IQueryable<Sale> query = _context.Sales
                .Include(q => q.Group)
                .Include(q => q.Product);
            query = query.Where(q => q.SaleId == id);
            return query.FirstOrDefault();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
