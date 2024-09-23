using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IArma arma = new Pistola();

            Jugador jugador = new Jugador(arma);

            jugador.DispararArma();

            jugador.CambiarArma(new AK47());

            jugador.DispararArma();

            Console.ReadKey();

        }
    }
}
