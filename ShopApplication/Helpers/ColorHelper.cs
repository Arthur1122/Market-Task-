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
            new ColorModel { Code = "#FFFF00", Name = "yellow" },
            new ColorModel { Code = "#32CD32", Name = "green" },
            new ColorModel { Code = "#00FF00", Name = "lime" },
            new ColorModel { Code = "#00FFFF", Name = "Cyan" },
            new ColorModel { Code = "#BDB76B", Name = "darkkhaki" },
            new ColorModel { Code = "#6A5ACD", Name = "slateblue" },
            new ColorModel { Code = "#DAA520", Name = "goldenrod" }
        };
    }
}
