using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal abstract class OrdenCommand
    {
        public abstract void Execute();

        protected ProductReceiver _producto;
        protected double _cantidad;

        protected OrdenCommand(ProductReceiver productReceiver, double cantidad)
        {
            _producto = productReceiver;
            _cantidad = cantidad;
        }


    }
}
