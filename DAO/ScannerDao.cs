using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace DAO
{
    public class ScannerDAO : DataProvider
    {
        public bool GetBarcode(String id)
        {
            string sql = "SELECT COUNT (*) FROM Products WHERE ProductID= '" + id + "'";
            int number;
            try
            {
                number = myExcuteScalar(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            if (number > 0)
            {
                return true;
            }
            else
                return false;
        }
        public List<Product> GetListProduct(string item)
        {
            List<Product> list = new List<Product>();
            string sql = "select * from Products WHERE ProductID = '" + item + "' or ProductName = N'" + item + "";
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
    }
}