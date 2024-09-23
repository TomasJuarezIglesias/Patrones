using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal interface IState
    {
        void ControlarEstado(Switch swt);

        void Describir();
    }
}
