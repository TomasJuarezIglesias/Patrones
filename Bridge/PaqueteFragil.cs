using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class PaqueteFragil : Paquete
    {
        public PaqueteFragil(Medio medioEntrega) : base(medioEntrega)
        {
        }

        public override void Entregar()
        {
            Console.WriteLine($"Entrega de paquete fragil por medio de {MedioEntrega.MedioEntrega()}");
        }
    }
}
