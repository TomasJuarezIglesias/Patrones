using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteIterator : IteratorEjemplo
    {
        private ConcreteCollection concreteCollection = new ConcreteCollection();
        private Item _item;

        public ConcreteIterator(ConcreteCollection concreteCollection)
        {
            this.concreteCollection = concreteCollection;
        }

        public override Item CurrentItem()
        {
            return _item;
        }

        public override void First()
        {
            _item = concreteCollection.Index(0);
        }

        public override bool IsDone()
        {
            if (concreteCollection.Count() == concreteCollection.Posicion() + 1)
            {
                return true;
            }

            return false;
        }

        public override void Siguiente()
        {
            _item = concreteCollection.Index(concreteCollection.Posicion() + 1);
        }
    }
}
