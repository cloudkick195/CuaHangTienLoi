using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
    public class SignOnBUS
    {
        public bool SignOn_ID(String ID)
        {
            try
            {
                return new SignOnDAO().SignOn_ID(ID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool SignOn_Pass(String pass)
        {
            try
            {
                return new SignOnDAO().SignOn_Pass(pass);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public String getNameID(String ID)
        {
            try
            {
                return new SignOnDAO().getNameID(ID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}