using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AutoPrototype auto = new Cronos("Cronos");


            AutoPrototype auto2 = auto.Clone();

            auto.Modelo = "Cronos 2";
            auto2.Modelo = "Cronos pro";

            Console.WriteLine(auto2.Modelo);
            Console.WriteLine(auto.Modelo);

            Console.ReadKey();


        }
    }
}
