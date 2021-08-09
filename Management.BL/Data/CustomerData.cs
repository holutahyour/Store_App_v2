using Management.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public class CustomerData
    {
        public Queue<Customer> customers = new Queue<Customer>();
        public void WriteCustomersDataToFile()
        {
            string filePath = @"../RegisterationDetails.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using FileStream fs = File.Create(filePath);
            fs.Dispose();
            var openedFile = File.AppendText(filePath);
            foreach (var customer in customers)
            {
                openedFile.WriteLine($"{customer.FirstName},{customer.LastName},{customer.Email},{customer.Password}");
            }
            openedFile.Dispose();
        }

        public void ReadCustomersDataFromFile()
        {
            string filePath = @"../RegisterationDetails.txt";
            if (!File.Exists(filePath))
            {
                using FileStream fs = File.Create(filePath);

            }
            var openedFile = File.ReadAllLines(filePath);

            foreach (var customerDetail in openedFile)
            {
                var data = customerDetail.Split(',');
                Customer customer = new Customer
                {
                    FirstName = data[0],
                    LastName = data[1],
                    Email = data[2],
                    Password = data[3]
                };

                customers.Enqueue(customer);
            }
            return;
        }
    }
}
