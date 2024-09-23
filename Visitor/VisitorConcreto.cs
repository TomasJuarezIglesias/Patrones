using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class VisitorConcreto : IVisitor
    {
        public void Visitar(Procesador procesador)
        {
            Console.WriteLine("Se visito al procesador");
        }

        public void Visitar(DiscoRigido discoRigido)
        {
            Console.WriteLine("Se visito al disco rigido");
        }
    }
}
