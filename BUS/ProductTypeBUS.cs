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
    public class ProductTypeBUS
    {
        public DataTable GetData()
        {
            return new ProductTypeDAO().GetData();
        }
        public DataTable FindItems(string item)
        {
            try
            {
                return new ProductTypeDAO().FindItems(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Insert(ProductType obj)
        {
            try
            {

                if (checkName(obj.productTypeName) == false)
                {
                    return 0;
                }
                
                return new ProductTypeDAO().Insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool checkName(string typeName)
        {
            try
            {
                return new ProductTypeDAO().checkName(typeName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update(ProductType obj)
        {
            try
            {

                return new ProductTypeDAO().Update(obj);

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
                return new ProductTypeDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
