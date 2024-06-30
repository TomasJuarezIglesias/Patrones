using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class CareTaker
    {
        private List<Memento> mementos;

        public CareTaker()
        {
            mementos = new List<Memento>();
        }

        public void AddMemento(Memento memento) 
        {
            mementos.Add(memento);
        }

        public Memento GetMemento(int index) 
        {
            Memento memento = mementos[index];

            mementos.RemoveAt(index);

            return memento;
        }
    }
}
