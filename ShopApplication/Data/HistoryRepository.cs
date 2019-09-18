using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopApplication.Data.Entities;

namespace ShopApplication.Data
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly MarketContext _context;

        public HistoryRepository(MarketContext context)
        {
            this._context = context;
        }

        public void Add(History history)
        {
            _context.Add(history);
        }

        public History[] GetAllHistory()
        {
            IQueryable<History> query = _context.Histories
                .Include(q => q.Product)
                .Include(q => q.Group)
                .Include(q => q.Sale);
            return query.ToArray();
        }

        public History[] GetHistoryByDateTime(DateTime FromDate, DateTime ToDate)
        {
            IQueryable<History> query = _context.Histories
                .Include(q => q.Product)
                .Include(q => q.Group)
                .Include(q => q.Sale);

            query = query.Where(q => q.Date >= FromDate);
            query = query.Where(q => q.Date <= ToDate);
            return query.ToArray();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges()>0;
        }
    }
}
