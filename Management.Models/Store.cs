using Management.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Models
{
    public class Store
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = Validations.CleanName(value); }
        }

        public string StoreNumber { get; set; }
        public string Type { get; set; }
        public string UserEmail { get; set; }
    }
}
