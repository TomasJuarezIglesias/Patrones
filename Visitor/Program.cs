﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Componente componente = new Procesador();



            componente.Aceptar(new VisitorConcreto());

            Console.ReadKey();
        }
    }
}
