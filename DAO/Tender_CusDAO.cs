using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class Tender_CusDAO:DataProvider
    {
        public Customer GetCustomer(string cusCode)
        {
            string sql ="SELECT * FROM Customer WHERE customerCode = '" + cusCode + "'";
            string cusName = "";
            string adress = "";
            string sdt = "";
            Customer customer;
            Connect();
            try
            {
                SqlDataReader dr = myExcuteReader(sql);
                while (dr.Read())
                {
                    cusName = dr[1].ToString();
                }
                customer = new Customer(cusCode, cusName, adress, sdt);
                dr.Close();
                return customer;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
