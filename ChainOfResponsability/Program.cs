using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aprobador comprador = new Comprador();
            Aprobador gerente = new Gerente();
            Aprobador director = new Director();


            comprador.AgregarSiguiente(gerente);
            gerente.AgregarSiguiente(director);


            Console.WriteLine("Ingrese importe a comprar ");
            string response = Console.ReadLine();

            comprador.AprobarCompra(int.Parse(response));

            Console.ReadKey();

        }
    }
}
