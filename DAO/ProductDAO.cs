using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace DAO
{
    public class ProductDAO : DataProvider
    {
        public DataTable GetData()
        {
            try
            {
                DataTable result = new DataTable();
                string sql = "SELECT * from Products";
                result = GetData(sql);
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();
            string sql = "select * from Products";
            SqlDataReader dr = myExcuteReader(sql);
            while (dr.Read())
            {

                list.Add(new Product(Convert.ToInt32(dr["ProductID"]),
                                                dr["ProductName"].ToString(),
                                                Convert.ToInt32(dr["SupplierID"]),
                                                Convert.ToInt32(dr["ProductTypeID"]),
                                                Convert.ToInt32(dr["Price"]),
                                                dr["Unit"].ToString(),
                                                Convert.ToInt32(dr["Amount"]),
                                                DateTime.Parse(dr["DateAdd"].ToString()),
                                                DateTime.Parse(dr["DateManufacture"].ToString()),
                                                DateTime.Parse(dr["DateExpiration"].ToString()),
                                                Convert.ToInt32(dr["sale"])
                                                ));
            }

            return list;
        }

        public DataTable FindItems(string item)
        {
            try
            {
                DataTable refult = new DataTable();
                string sql = "SELECT * from Products WHERE ProductID like '%" + item + "%' or ProductName like N'%" + item + "%'";
                refult = GetData(sql);
                return refult;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Insert(Product objProduct)
        {
            try
            {
                int result = 0;
                string sql = "insert into Products(ProductName, SupplierID, ProductTypeID, Price, Unit, Amount, DateAdd, DateManufacture, DateExpiration, Sale) " +
                    "values(N'" + objProduct.ProductName + "','" + objProduct.SupplierID + "','" + objProduct.ProductTypeID + "','" + objProduct.Price + "',N'" + objProduct.Unit + "','" + objProduct.Amount + "','" + objProduct.DateAdd + "','" + objProduct.DateManufacture + "','" + objProduct.DateExpiration + "','" + objProduct.Sale + "')";
                result = myExcuteNonQuery(sql);
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Update(Product objProduct)
        {
            try
            {
                int result = 0;
                string sql = "update Products set ProductName = N'" + objProduct.ProductName + "', SupplierID = '" + objProduct.SupplierID + "', ProductTypeID = '" + objProduct.ProductTypeID + "', Price = '" + objProduct.Price + "', Unit = N'" + objProduct.Unit + "', Amount = '" + objProduct.Amount + "', DateAdd = '" + objProduct.DateAdd + "', DateManufacture = '" + objProduct.DateManufacture + "', DateExpiration = '" + objProduct.DateExpiration + "', Sale = '" + objProduct.Sale + "' WHERE ProductID = '" + objProduct.ProductID + "'";
                result = myExcuteNonQuery(sql);
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Delete(int ProductID)
        {
            try
            {
                int result = 0;
                string sql = "delete from Products where ProductID = '" + ProductID + "' ";
                result = myExcuteNonQuery(sql);
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
