using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class UserSingleton
    {
        public int Id { get; set; }

        private static readonly UserSingleton userSingleton;

        private UserSingleton()
        {
            Random random = new Random();
            Id = random.Next();
        }

        public static UserSingleton GetInstance()
        {
            return userSingleton is null ? new UserSingleton() : userSingleton;
        }
    }
}
