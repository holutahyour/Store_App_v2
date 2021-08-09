using Management.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public class StoreData
    {
        public Queue<Store> stores = new Queue<Store>();
        public void WriteStoresDataToFile()
        {
            string filePath = @"../StoreDetails.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using FileStream fs = File.Create(filePath);
            fs.Dispose();
            var openedFile = File.AppendText(filePath);
            foreach (var store in stores)
            {
                openedFile.WriteLine($"{store.Name},{store.StoreNumber},{store.Type},{store.UserEmail}");
            }
            openedFile.Dispose();
        }

        public void ReadStoresDataFromFile()
        {
            string filePath = @"../StoreDetails.txt";
            if (!File.Exists(filePath))
            {
                using FileStream fs = File.Create(filePath);

            }
            var openedFile = File.ReadAllLines(filePath);

            foreach (var storeDetail in openedFile)
            {
                var data = storeDetail.Split(',');
                Store store = new Store
                {
                    Name = data[0],
                    StoreNumber = data[1],
                    Type = data[2],
                    UserEmail = data[3]
                };

                stores.Enqueue(store);
            }
            return;
        }
    }
}
