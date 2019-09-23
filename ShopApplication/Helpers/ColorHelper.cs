using ShopApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Helpers
{
    public static class ColorHelper
    {
        public static List<ColorModel> ColorList = new List<ColorModel>
        {
            new ColorModel { Code = "Code1", Name = "Name1" },
            new ColorModel { Code = "Code2", Name = "Name2" }
        };
    }
}
