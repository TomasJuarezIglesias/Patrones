using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class AutoPrototype
    {
        public string Modelo { get; set; }

        public AutoPrototype(string modelo)
        {
            Modelo = modelo;
        }

        public abstract AutoPrototype Clone();

    }
}
