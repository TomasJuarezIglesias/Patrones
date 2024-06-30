using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public abstract class Collection
    {
        public abstract IteratorEjemplo CreateIterator();
        public abstract void Agregar(Item item);
        public abstract Item Index(int index);
        public abstract int Count();
        public abstract int Posicion();

    }
}
