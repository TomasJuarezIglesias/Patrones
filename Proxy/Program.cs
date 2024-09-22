using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Session session = new Session();
            session.CanGetAll = true;

            IRepository repository = new ProxyRepository(session);

            List<Customer> customers = repository.GetAll();


            foreach (Customer customer in customers) 
            {
                Console.WriteLine(customer.Nombre);
            }

            Console.ReadKey();
        }
    }
}
