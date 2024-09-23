using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Jugador
    {
        private IArma _arma;

        public Jugador(IArma arma)
        {
            _arma = arma; 
        }

        public void CambiarArma(IArma arma)
        {
            _arma = arma;
        }

        public void DispararArma()
        {
            _arma.Disparar();
        }
    }
}
