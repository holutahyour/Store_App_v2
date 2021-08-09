using Management.BL;
using Management.Commons;
using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Ul
{
    public class Dashboard
    {
        public Customer user;

        public static void DisplayDashBoard(ICustomerActions customerActions)
        {
            bool shouldRun = true;
            while (shouldRun)
            {
                Customer user = new Customer();
                Console.WriteLine("Welcome to Store App");
                Console.WriteLine("Select any of the following options: ");
                Console.WriteLine("1 to Register new customer");
                Console.WriteLine("2 to Login to your account");
                Console.WriteLine("3 to Show list of all customers");

                var consoleInput = Validations.IsValidInput(Console.ReadLine());
                if (consoleInput == -1)
                {
                    Console.WriteLine("Please enter a valid input");
                }
                else
                {
                    switch (consoleInput)
                    {
                        case 1:
                            try
                            {
                                CustomerUI.CustomerRegistration(customerActions);
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.ReadKey();
                                Console.Clear();
                                throw;
                            }
                            break;
                        case 2:
                            try
                            {
                                CustomerUI.CustomerLogin(customerActions,user);
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.ReadKey();
                                Console.Clear();
                                throw;
                            }
                            break;
                        case 3:
                            try
                            {
                                CustomerUI.DisplayAllCustomer(customerActions);
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.ReadKey();
                                Console.Clear();
                                throw;
                            }
                            break;
                    }
                }
            }
        }
    }
}
