using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ModerFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }
    }
}
