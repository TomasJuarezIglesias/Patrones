using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class MedioTerrestre : Medio
    {
        public MedioTerrestre(string formaEntrega) : base(formaEntrega)
        {
        }

        public override string MedioEntrega()
        {
            return FormaEntrega;
        }
    }
}
