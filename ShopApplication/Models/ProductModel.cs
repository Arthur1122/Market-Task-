using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public int CodeProduct { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int GroupId { get; set; }
        public string ProductColor { get; set; }

    }
}
