using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Logistics
    {
        public void PlanDelivery()
        {
            Console.WriteLine("Planning delivery");
        }

        public abstract ITransport CreateTransport();
    }
}
