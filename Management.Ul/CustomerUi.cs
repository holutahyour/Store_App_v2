using Management.BL;
using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Ul
{
    public class CustomerUI
    {
        private static string firstName;
        private static string lastName;
        private static string emailAddress;
        private static string password;
        


        public static void CustomerRegistration(ICustomerActions customerActions)
        {
            Console.WriteLine("Enter first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter email address");
            emailAddress = Console.ReadLine();
            Console.WriteLine("Enter Password");
            password = Console.ReadLine();
            Customer customer = customerActions.AddCustomer(lastName, firstName, emailAddress, password);
            Console.WriteLine($"Customer {customer.FullName} added successfully");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }

        public static Customer CustomerLogin(ICustomerActions customerActions, Customer user)
        {
            Console.WriteLine("Enter email address");
            emailAddress = Console.ReadLine();
            Console.WriteLine("Enter Password");
            password = Console.ReadLine();
            user = customerActions.Login(emailAddress, password);
            Console.WriteLine($"Customer {user.FullName} added successfully");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            return user;
        }

        public static void DisplayAllCustomer(ICustomerActions customerActions)
        {
            var customers = customerActions.DisplayCustomers();
            Console.ForegroundColor = ConsoleColor.Green;
            UIHelpers.DisplayCustomerTable(customers);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
