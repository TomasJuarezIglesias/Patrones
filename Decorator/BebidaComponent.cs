using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class BebidaComponent
    {
        public abstract string Descripcion { get; }
        public abstract double Costo { get;}
    }
}
