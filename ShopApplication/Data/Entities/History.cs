using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data.Entities
{
    public class History
    {
        public int HistoryId { get; set; }
        public Product Product { get; set; }
        public Sale Sale { get; set; }
        public Group Group { get; set; }
        public DateTime Date { get; set; }
    }
}
