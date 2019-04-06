using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int ProductTypeID { get; set; }
        public int Price { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateManufacture { get; set; }
        public DateTime DateExpiration { get; set; }

        public int Sale { get; set; }

        public Product(int ProductID, string ProductName, int SupplierID, int ProductTypeID, int Price, string Unit, int Amount, DateTime DateAdd, DateTime DateManufacture, DateTime DateExpiration, int Sale)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.SupplierID = SupplierID;
            this.ProductTypeID = ProductTypeID;
            this.Price = Price;
            this.Unit = Unit;
            this.Amount = Amount;
            this.DateAdd = DateAdd;
            this.DateManufacture = DateManufacture;
            this.DateExpiration = DateExpiration;
            this.Sale = Sale;
        }
        public Product(int SupplierID, int ProductTypeID, int Price, string Unit, int Amount, DateTime DateAdd, DateTime DateManufacture, DateTime DateExpiration, int sale)
        {
            this.ProductName = ProductName;
            this.SupplierID = SupplierID;
            this.ProductTypeID = ProductTypeID;
            this.Price = Price;
            this.Unit = Unit;
            this.Amount = Amount;
            this.DateAdd = DateAdd;
            this.DateManufacture = DateManufacture;
            this.DateExpiration = DateExpiration;
            this.Sale = Sale;
        }
    }
}