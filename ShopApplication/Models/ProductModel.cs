using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [BindRequired]
        public string ProductColor { get; set; }

    }
}
