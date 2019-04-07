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
    public class ScannerBUS
    {
        public bool GetBarcode(String barcode)
        {
            try
            {

                return new ScannerDAO().GetBarcode(barcode);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<Product> GetListProduct(string item)
        {
            try
            {
                return new ScannerDAO().GetListProduct(item);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}