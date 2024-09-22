using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Cronos : AutoPrototype
    {
        public Cronos(string modelo) : base(modelo)
        {
        }

        public override AutoPrototype Clone()
        {
            return (Cronos)this.MemberwiseClone();
        }
    }
}
