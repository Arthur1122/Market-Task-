using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data.Entities
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime dateTime { get; set; }
        public Group Group { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}
