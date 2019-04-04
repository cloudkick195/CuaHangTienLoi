using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductType
    {
        public int productTypeID { get; set; }
        public string productTypeName { get; set; }
        public string describe{ get; set; }

        public ProductType(int productTypeID, string productTypeName, string describe)
        {
            this.productTypeID = productTypeID;
            this.productTypeName = productTypeName;
            this.describe = describe;
        }
        public ProductType(string productTypeName, string describe)
        {
            this.productTypeName = productTypeName;
            this.describe = describe;
        }
    }
}
