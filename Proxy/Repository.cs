using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Repository : IRepository
    {
        public List<Customer> GetAll()
        {
            return new List<Customer> 
            { 
                new Customer("Tomito"),
                new Customer("Facundo")
            };
        }
    }
}
