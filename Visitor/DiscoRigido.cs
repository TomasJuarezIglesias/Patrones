using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class DiscoRigido : Componente
    {
        public override void Aceptar(IVisitor visitor)
        {
            visitor.Visitar(this);
        }

        public void HacerAlgo()
        {
            Console.WriteLine("Ejecutado desde visitor");
        }
    }
}
