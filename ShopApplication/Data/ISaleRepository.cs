using ShopApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data
{
    public interface ISaleRepository
    {
        Sale[] GetAllSales();
        Sale GetSaleById(int id);
        void Add(Sale sale);
        void Delete(Sale sale);
        bool SaveChanges();

    }
}
