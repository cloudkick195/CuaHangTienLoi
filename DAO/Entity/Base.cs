using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public abstract class Base<T> where T : class
    {
        public abstract string Insert(T entity);
        public int Result()
        {
            return 1;
        }
    }
}
