using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal class Director : Aprobador
    {

        public override void AprobarCompra(int importe)
        {
            Console.WriteLine("Aprobada por director");
        }
    }
}
