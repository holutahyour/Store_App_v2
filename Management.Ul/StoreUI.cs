using Management.BL;
using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Ul
{
    public class StoreUI
    {
        private static string name;
        private static string type;
       


        public static void StoreRegistration(IStoreActions storeActions,Customer user)
        {
            if (user.Email == null)
            {
                throw new FormatException("Email is Null");
            }
            Console.WriteLine("Enter Store name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Store Type");
            type = Console.ReadLine();
            Store store = storeActions.AddStore(name, type, user.Email);
            Console.WriteLine($"Store {store.Name} added successfully");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }

        public static void DisplayAllStore(IStoreActions storeActions,string userEmail)
        {
            var stores = storeActions.DisplayStores(userEmail);
            Console.ForegroundColor = ConsoleColor.Green;
            UIHelpers.DisplayStoreTable(stores);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
