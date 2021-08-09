using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public class DataAccessFactory
    {
        public static ICustomerActions GetCustomerActions()
        {
            return new CustomerActions();
        }
    }
}
