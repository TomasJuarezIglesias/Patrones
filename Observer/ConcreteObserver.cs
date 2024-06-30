using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObserver : IObserver
    {
        public int NumeroObservador { get; set; }

        public ConcreteObserver(int numeroObservador)
        {
            NumeroObservador = numeroObservador;    
        }

        public void Notify()
        {
            Console.WriteLine($"Observador {NumeroObservador} concreto notificado");
        }
    }
}
