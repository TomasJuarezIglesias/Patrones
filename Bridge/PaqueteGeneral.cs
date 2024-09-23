using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class PaqueteGeneral : Paquete
    {
        public PaqueteGeneral(Medio medioEntrega) : base(medioEntrega)
        {
        }

        public override void Entregar()
        {
            Console.WriteLine($"Paquete general entregado por medio {MedioEntrega.MedioEntrega()}");
        }
    }
}
