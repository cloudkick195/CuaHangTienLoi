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
    public class SupplierBUS
    {
        public DataTable GetData()
        {
            return new SupplierDAO().GetData();
        }

        public List<Supplier> GetListSupplier()
        {
            return new SupplierDAO().GetListSupplier();
        }
        public DataTable FindItems(string item)
        {
            try
            {
                return new SupplierDAO().FindItems(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Insert(Supplier obj)
        {
            try
            {

                if (checkName(obj.supplierName) == false)
                {
                    return 0;
                }
                
                return new SupplierDAO().Insert(obj);
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
                return new SupplierDAO().checkName(typeName);
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

                return new SupplierDAO().Update(obj);

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
                return new SupplierDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
