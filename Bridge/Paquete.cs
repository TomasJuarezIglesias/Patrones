using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal abstract class Paquete
    {
        protected Medio MedioEntrega { get; set; }

        protected Paquete(Medio medioEntrega)
        {
            MedioEntrega = medioEntrega;
        }

        public abstract void Entregar();

    }
}
