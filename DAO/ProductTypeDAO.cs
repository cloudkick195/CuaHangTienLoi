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
    public class ProductTypeDAO : DataProvider
    {
        public DataTable GetData()
        {
            try
            {
                DataTable result = new DataTable();
                string sql = "SELECT * from Categories";
                result = GetData(sql);
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable FindItems(string item)
        {
            try
            {
                DataTable refult = new DataTable();
                string sql = "SELECT * from Categories WHERE ProductTypeID like '%" + item + "%' or ProductTypeName like N'%" + item + "%'";
                refult = GetData(sql);
                return refult;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Insert(ProductType objProductType)
        {
            try
            {
                int result = 0;
                string sql = "insert into Categories(ProductTypeName, Describe) values(N'" + objProductType.productTypeName + "',N'" + objProductType.describe + "')";
                result = myExcuteNonQuery(sql);
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Update(ProductType objProductType)
        {
            try
            {
                int result = 0;
                string sql = "update Categories set ProductTypeName = N'" + objProductType.productTypeName + "', Describe = N'" + objProductType.describe + "' WHERE ProductTypeID = '"+ objProductType.productTypeID+ "'";
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
                string sql = "SELECT ProductTypeName FROM Categories WHERE ProductTypeName = '" + typeName + "'";
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
        public int Delete(int productTypeID)
        {
            try
            {
                int result = 0;
                string sql = "delete from Categories where ProductTypeID = '" + productTypeID + "' ";
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
