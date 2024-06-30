using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ChatRoom : IChat
    {
        private Usuario _usuario1;
        private Usuario _usuario2;

        public ChatRoom(Usuario usuario1, Usuario usuario2)
        {
            _usuario1 = usuario1;
            _usuario2 = usuario2;
        }

        public void Enviar(string mensaje, Usuario usuario)
        {
            if (usuario != _usuario1)
            {
                _usuario2.Recibir(mensaje);
            }
            else
            {
                _usuario1.Recibir(mensaje);
            }
        }
        

    }
}
