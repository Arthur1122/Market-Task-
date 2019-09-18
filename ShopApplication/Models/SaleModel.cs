using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Models
{
    public class SaleModel
    {
        public int SaleId { get; set; }
        public DateTime dateTime { get; set; }
        public int GroupId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
    }
}
