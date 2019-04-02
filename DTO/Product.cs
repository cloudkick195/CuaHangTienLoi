using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public string proName { get; set; }
        public string netW { get; set; }
        public float sellingP { get; set; }
        public Product(string proName, string netW, float sellingP)
        {
            this.proName = proName;
            this.netW = netW;
            this.sellingP = sellingP;
        }
    }
}