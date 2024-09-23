using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class EmpresaInvoker
    {
        private readonly List<OrdenCommand> _comands;

        public EmpresaInvoker()
        {
            _comands = new List<OrdenCommand>();
        }

        public void AgregarCommand(OrdenCommand comando)
        {
            _comands.Add(comando);
        }


        public void Procesar()
        {
            foreach (var comando in _comands) 
            { 
                comando.Execute();
            }

            _comands.Clear();
        }
    }
}
