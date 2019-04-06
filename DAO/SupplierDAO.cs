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
    public class SupplierDAO : DataProvider
    {
        public DataTable GetData()
        {
            try
            {
                DataTable refult = new DataTable();
                string sql = "select * from Suppliers";
                refult = GetData(sql);
                return refult;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<Supplier> GetListSupplier()
        {
            List<Supplier> list = new List<Supplier>();
            string sql = "select SupplierID,SupplierName from Suppliers";
            SqlDataReader dr = myExcuteReader(sql);
            while (dr.Read())
            {

                list.Add(new Supplier(Convert.ToInt32(dr["SupplierID"]),
                                                dr["SupplierName"].ToString(),
                                                "","",""));
            }

            return list;
        }

        public DataTable FindItems(string item)
        {
            try
            {
                DataTable refult = new DataTable();
                string sql = "select * from Suppliers where SupplierID like N'%" + item + "%' or SupplierName like N'%" + item + "%'";
                refult = GetData(sql);
                return refult;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Insert(Supplier obj)
        {
            try
            {
                int result = 0;
                string sql = "insert into Suppliers(SupplierName, Email, Address, PhoneNumber) values(N'" + obj.supplierName + "',N'" + obj.email + "',N'" + obj.address + "','" + obj.phoneNumber + "')";
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
                string sql = "SELECT SupplierName FROM Suppliers WHERE SupplierName = N'" + typeName + "'";
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

        public int Update(Supplier obj)
        {
            try
            {
                int result = 0;
                string sql = "update Suppliers set SupplierName = N'" + obj.supplierName + "' , Email = N'" + obj.email + "', Address = N'" + obj.address + "', PhoneNumber = N'" + obj.phoneNumber + "' where SupplierID = N'" + obj.supplierID + "'";
                result = myExcuteNonQuery(sql);
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Delete(int id)
        {
            try
            {
                int result = 0;
                string sql = "delete from Suppliers where SupplierID = '" + id + "' ";
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
