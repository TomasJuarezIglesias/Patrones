using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Cafe : BebidaComponent
    {
        public override string Descripcion => "Cafe";

        public override double Costo => 25;
    }
}
