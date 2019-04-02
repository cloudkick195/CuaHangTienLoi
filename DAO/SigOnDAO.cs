using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace DAO
{
    public class SignOnDAO : DataProvider
    {
        public bool SignOn_ID(String ID)
        {
            string sql = "SELECT COUNT (*) FROM Employees WHERE EmployeeID= '" + ID + "'";
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
        public String getNameID(String ID)
        {
            string sql = "SELECT * FROM Employees WHERE EmployeeID= '" + ID + "'";
            String name = "";
            Connect();
            try
            {
                SqlDataReader dr = myExcuteReader(sql);
                while (dr.Read())
                {
                    name = dr[1].ToString();
                }
                dr.Close();
                return name;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
        public bool SignOn_Pass(String Pass)
        {
            string sql = "SELECT COUNT (*) FROM Employees WHERE Password= '" + Pass + "'";
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
    }
}