using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Procesador : Componente
    {
        public override void Aceptar(IVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
