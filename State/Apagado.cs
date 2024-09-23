using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Apagado : IState
    {
        public void ControlarEstado(Switch swt)
        {
            swt.CambiarEstado(new Encendido());
        }

        public void Describir()
        {
            Console.WriteLine("Estado apagado bro");
        }
    }
}
