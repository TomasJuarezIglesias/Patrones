using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteCollection : Collection
    {
        private List<Item> _listaItems = new List<Item>();
        private Item _item;
        private int _posicion;

        public override void Agregar(Item item)
        {
            _listaItems.Add(item);
        }

        public override int Count()
        {
            return _listaItems.Count;
        }

        public override IteratorEjemplo CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public override Item Index(int index)
        {
            _item = _listaItems[index];
            _posicion = index;
            return _item;
        }

        public override int Posicion()
        {
            return _posicion;
        }
    }
}
