using Management.Commons;
using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public class CustomerActions : ICustomerActions
    {
        private readonly CustomerData store;
        
        public CustomerActions()
        {
            store = new CustomerData();
            store.ReadCustomersDataFromFile();
        }

        public Customer AddCustomer(string lastName, string firstName, string email, string password)
        {
            if (!Validations.IsEmailValid(email))
                throw new FormatException("Email is not valid");
            Customer newCustomer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };

            store.customers.Enqueue(newCustomer);
            store.WriteCustomersDataToFile();
            return newCustomer;
        }

        public Customer Login(string email, string password)
        {
            if (!Validations.IsEmailValid(email))
                throw new FormatException("Enter a correct Email");
            foreach (var customer in store.customers)
            {
                if (customer.Email == email && customer.Password == password)
                {
                    return customer;
                }
            }

            throw new FormatException("Invalid Email/Password");
        }

        public string DequeueUser()
        {
            throw new NotImplementedException();
        }

        public Queue<Customer> DisplayCustomers()
        {
            return store.customers;
        }
    }
}
