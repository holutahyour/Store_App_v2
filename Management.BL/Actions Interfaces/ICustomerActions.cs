using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public interface ICustomerActions
    {
        Customer AddCustomer(string lastName, string firstName, string email, string password);
        Customer Login(string email, string password);
        Queue<Customer> DisplayCustomers();
    }
}
