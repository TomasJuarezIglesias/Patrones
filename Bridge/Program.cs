using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medio medioDeEntrega = new MedioAereo("Aereo");

            Paquete paquete = new PaqueteFragil(medioDeEntrega);

            paquete.Entregar();

            medioDeEntrega = new MedioTerrestre("Terrestre");

            paquete = new PaqueteGeneral(medioDeEntrega);

            paquete.Entregar();

            Console.ReadKey();

        }
    }
}
