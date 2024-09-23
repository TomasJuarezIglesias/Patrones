using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal abstract class Componente
    {

        public abstract void Aceptar(IVisitor visitor);
    }
}
