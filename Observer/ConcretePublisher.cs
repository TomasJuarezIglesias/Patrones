using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcretePublisher : IPublisher
    {
        private readonly List<IObserver> _subscribers;
        public ConcretePublisher()
        {
            _subscribers = new List<IObserver>();
        }

        public void NotifyAll()
        {
            foreach (var item in _subscribers)
            {
                item.Notify();
            }
        }

        public void AddObserver(IObserver observer)
        {
            _subscribers.Add(observer);
        }


        public void RemoveObserver(IObserver observer)
        {
            _subscribers.Remove(observer);
        }
    }
}
