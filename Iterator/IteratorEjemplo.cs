using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public abstract class IteratorEjemplo
    {
        public abstract void First();
        public abstract void Siguiente();
        public abstract bool IsDone();
        public abstract Item CurrentItem();

    }
}
