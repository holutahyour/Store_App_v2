using Management.Commons;
using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public class StoreActions : IStoreActions
    {
        private readonly StoreData store;
        
        public StoreActions()
        {
            store = new StoreData();
            store.ReadStoresDataFromFile();
        }

        public Store AddStore(string name, string type, string userEmail)
        {
            //if (!Validations.IsEmailValid(email))
            //    throw new FormatException("Email is not valid");
            Random rnd = new Random();

            Store newStore = new Store
            {
                Name = name,
                Type = type,
                UserEmail = userEmail,
                StoreNumber = rnd.Next(10000,100000000).ToString()
            };

            store.stores.Enqueue(newStore);
            store.WriteStoresDataToFile();
            return newStore;
        }        

        public string DequeueUser()
        {
            throw new NotImplementedException();
        }

        public Queue<Store> DisplayStores()
        {
            return store.stores;
        }
        public Queue<Store> DisplayStores(string userEmail)
        {
            Queue<Store> queueStore = new Queue<Store>();

            var newStores = store.stores
                            .Where(x => x.UserEmail == userEmail)
                            .ToList();
            foreach (var newStore in newStores)
            {
                queueStore.Enqueue(newStore);
            }

            return queueStore;
        }
    }
}
