using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class MedioAereo : Medio
    {
        public MedioAereo(string formaEntrega) : base(formaEntrega)
        {
        }

        public override string MedioEntrega()
        {
            return FormaEntrega;
        }
    }
}
