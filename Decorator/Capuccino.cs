using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Capuccino : BebidaComponent
    {

        public override string Descripcion => "Capuccino";

        public override double Costo => 20;
    }
}
