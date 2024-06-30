using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Persona
    {

        public string Nombre { get; set; }

        public Memento SaveToMemento()
        {
            Console.WriteLine("Originator: Guardando memento para " + Nombre);
            return new Memento(Nombre);
        }

        public void Restore(Memento memento)
        {
            Nombre = memento.GetEstado();
            Console.WriteLine("Originator: Recuperando memento " + Nombre);
        }
    }
}
