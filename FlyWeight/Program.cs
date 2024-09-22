using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seleccion = -1;

            FlyWeightFactory factory = new FlyWeightFactory();

            while (seleccion != 0) 
            {
                Console.WriteLine("Ingrese modelo a cargar o ingrese 0 para salir");
                string response = Console.ReadLine();

                if (int.TryParse(response, out int numero))
                {
                    if (numero == 0) break;
                }

                if (string.IsNullOrEmpty(response))
                {
                    Console.WriteLine("Datos ingresados incorrectos");
                    continue;
                }

                IFlyWeight auto = factory.GetAuto(response);

                Console.WriteLine($"Auto ingresado {auto.ObtenerNombre()}");   
            }


            Console.WriteLine($"Instancias generadas {factory.CantidadInstancias()}");
            Console.ReadKey();

        }
    }
}
