using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
    public class Tender_CusBUS
    {
        public Customer GetCustomer(string cusCode)
        {
            try
            {
                return new Tender_CusDAO().GetCustomer(cusCode);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
