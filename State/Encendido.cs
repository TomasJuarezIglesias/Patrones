using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Encendido : IState
    {
        public void ControlarEstado(Switch swt)
        {
            swt.CambiarEstado(new Apagado());
        }

        public void Describir()
        {
            Console.WriteLine("Estado encendido bro");
        }
    }
}
