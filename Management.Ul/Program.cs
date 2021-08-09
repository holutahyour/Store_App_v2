using Management.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Ul
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var customerAction = DataAccessFactory.GetCustomerActions();
                var storeAction = DataAccessFactory.GetStoreActions();
                Dashboard.DisplayDashBoard(customerAction, storeAction);
            }
            catch (Exception)
            {

                Console.WriteLine("Unable to start application");
            }
        }
    }
}
