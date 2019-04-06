using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Supplier
    {
        public int supplierID { get; set; }
        public string supplierName { get; set; }
        public string email { get; set; }

        public string address { get; set; }
        public string phoneNumber { get; set; }

        public Supplier(int supplierID, string supplierName, string email, string address, string phoneNumber)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName;
            this.email = email;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }
        public Supplier(string supplierName, string email, string address, string phoneNumber)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName;
            this.email = email;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }
    }
}
