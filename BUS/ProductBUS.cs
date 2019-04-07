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
    public class ProductBUS
    {
        public DataTable GetData()
        {
            return new ProductDAO().GetData();
        }
        public List<Product> GetListProduct()
        {
            return new ProductDAO().GetListProduct();
        }
        public DataTable FindItems(string item)
        {
            try
            {
                return new ProductDAO().FindItems(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Insert(Product obj)
        {
            return new ProductDAO().Insert(obj);
        }


        public int Update(Product obj)
        {
            try
            {

                return new ProductDAO().Update(obj);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(int id)
        {
            try
            {
                return new ProductDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
