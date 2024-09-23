using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class AK47 : IArma
    {
        public void Disparar()
        {
            Console.WriteLine("Disparo un AK47");
        }
    }
}
