using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal abstract class Aprobador
    {
        protected Aprobador _siguiente { get; set; }

        public void AgregarSiguiente(Aprobador aprobador)
        {
            _siguiente = aprobador; 
        }

        public abstract void AprobarCompra(int importe);
    }
}
