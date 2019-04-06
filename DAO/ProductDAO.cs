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
                                                ""));
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
                string sql = "insert into Products(ProductName, Describe) values(N'" + objProduct.ProductName + "',N'" + objProduct.describe + "')";
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
                string sql = "update Products set ProductName = N'" + objProduct.ProductName + "', Describe = N'" + objProduct.describe + "' WHERE ProductID = '" + objProduct.ProductID + "'";
                result = myExcuteNonQuery(sql);
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool checkName(string typeName)
        {
            try
            {
                string sql = "SELECT ProductName FROM Products WHERE ProductName = '" + typeName + "'";
                DataTable dt = new DataTable();
                dt = GetData(sql);
                if (dt.Rows.Count > 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
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
