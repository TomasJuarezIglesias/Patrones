using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ProxyRepository : IRepository
    {
        private readonly IRepository _repository;
        private readonly Session _session;

        public ProxyRepository(Session session)
        {
            _session = session;
            _repository = new Repository();
        }

        public List<Customer> GetAll()
        {
            if (CheckPermisson())
            {
                throw new UnauthorizedAccessException();
            }
            
            return _repository.GetAll();
        }


        private bool CheckPermisson()
        {
            return _session.CanGetAll;
        }
    }
}
