using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public string cusCode { get; set; }
        public string cusName { get; set; }
        public string Address { get; set; }
        public string SDT { get; set; }
        public Customer()
        {
            this.cusCode = "";
            this.cusName = "";
            this.Address = "";
            this.SDT = "";
        }
        public Customer(string code, string name, string adress, string sdt)
        {
            this.cusCode = code;
            this.cusName = name;
            this.Address = adress;
            this.SDT = sdt;
        }
    }
}
