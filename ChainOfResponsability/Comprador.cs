using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal class Comprador : Aprobador
    {

        public override void AprobarCompra(int importe)
        {
            if (importe > 100)
            {
                _siguiente.AprobarCompra(importe);
                return;
            }

            Console.WriteLine("Aprobada por comprador");
        }
    }
}
