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
        public Product GetProducts(String barcode)
        {
            try
            {
                return new ScannerDAO().GetProducts(barcode);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}