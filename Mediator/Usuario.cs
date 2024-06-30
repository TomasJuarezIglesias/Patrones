using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Usuario : BaseComponent
    {
        public string Nombre { get; set; }

        public void Enviar(string mensaje, Usuario usuario)
        {
            this._chat.Enviar(mensaje, usuario);
        }

        public void Recibir(string mensaje)
        {
            Console.WriteLine($"{Nombre} recibio el mensaje {mensaje}");
        }
    }
}
