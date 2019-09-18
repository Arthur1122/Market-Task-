using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data.Entities
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int GroupCode { get; set; }
        public string Color { get; set; }
    }
}
