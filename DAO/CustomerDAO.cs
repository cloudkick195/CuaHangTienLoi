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
    public class CustomerDAO : DataProvider
    {
        public DataTable GetData()
        {
            try
            {
                DataTable refult = new DataTable();
                string sql = "select * from Customers";
                refult = GetData(sql);
                return refult;
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
                string sql = "select * from Customers where customerCode like '%" + item + "%' or customerName like '%" + item + "%'";
                refult = GetData(sql);
                return refult;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Insert(Customer objCus)
        {
            try
            {
                int result = 0;
                string sql = "insert into Customers(customerCode, customerName, Address, SDT) values('" + objCus.cusCode + "','" + objCus.cusName + "','" + objCus.Address + "','" + objCus.SDT + "')";
                result = myExcuteNonQuery(sql);
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool checkCode(string Makh)
        {
            try
            {
                bool refult = true;
                string sql = "select customerCode from Customers where customerCode = '" + Makh + "'";
                DataTable dt = new DataTable();
                dt = GetData(sql);
                if (dt.Rows.Count > 0)
                {
                    return false;
                }
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Update(Customer objCus)
        {
            try
            {
                int result = 0;
                string sql = "update customer set customerCode = '" + objCus.cusCode + "', customerName ='" + objCus.cusName + "' , Address = '" + objCus.Address + "', SDT = '" + objCus.SDT + "' where customerCode = '" + objCus.cusCode + "'";
                result = myExcuteNonQuery(sql);
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Delete(string Makh)
        {
            try
            {
                int result = 0;
                string sql = "delete from customer where customerCode = '" + Makh + "' ";
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
