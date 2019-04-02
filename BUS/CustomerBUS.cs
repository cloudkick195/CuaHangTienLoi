using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class CustomerBUS
    {
        public DataTable GetData()
        {
            try
            {
                return new CustomerDAO().GetData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable FindItems(string item)
        {
            try
            {
                return new CustomerDAO().FindItems(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Insert(Customer objCus)
        {
            try
            {

                if (checkCode(objCus.cusCode) == false)
                {
                    return false;
                }
                new CustomerDAO().Insert(objCus);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool checkCode(string Makh)
        {
            try
            {
                return new CustomerDAO().checkCode(Makh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(Customer objCus)
        {
            try
            {

                return new CustomerDAO().Update(objCus);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(string Makh)
        {
            try
            {
                return new CustomerDAO().Delete(Makh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
