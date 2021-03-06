using Management.Commons;
using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Ul
{
    public class UIHelpers
    {
        public static void DisplayCustomerTable(Queue<Customer> customers)
        {
            DisplayTable.PrintLine();
            DisplayTable.PrintRow("Full Name", "Email Address");
            DisplayTable.PrintLine();

            foreach (var customer in customers)
            {
                DisplayTable.PrintRow(customer.FullName, customer.Email);
                DisplayTable.PrintLine();
            }
        }
        public static void DisplayStoreTable(Queue<Store> stores)
        {
            DisplayTable.PrintLine();
            DisplayTable.PrintRow("Name", "Store Number","Type");
            DisplayTable.PrintLine();

            foreach (var store in stores)
            {
                DisplayTable.PrintRow(store.Name, store.StoreNumber, store.Type);
                DisplayTable.PrintLine();
            }
        }
    }
}
