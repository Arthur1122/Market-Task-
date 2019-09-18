using ShopApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data
{
    public interface IHistoryRepository
    {
        History[] GetAllHistory();
        History[] GetHistoryByDateTime(DateTime FromDate, DateTime ToDate);
        void Add(History history);
        bool SaveChanges();
    }
}
