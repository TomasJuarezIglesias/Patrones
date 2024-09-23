using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Switch
    {
        private IState _state;

        public Switch()
        {
            _state = new Encendido();
        }

        public void CambiarEstado(IState state)
        {
            _state = state;
        }


        public void Presionar()
        {
            _state.Describir();
            _state.ControlarEstado(this);
        }

    }
}
