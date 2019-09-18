using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Models
{
    public class HistoryModel
    {
        public int HistoryId { get; set; }
        public int ProductId { get; set; }
        public int SaleId { get; set; }
        public int GroupId { get; set; }
        public DateTime Date { get; set; }
    }
}
