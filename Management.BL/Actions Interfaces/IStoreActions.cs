using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public interface IStoreActions
    {
        Store AddStore(string name, string type, string userEmail);
        Queue<Store> DisplayStores(string userEmail);
    }
}
