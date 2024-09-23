using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal abstract class Medio
    {
        public string FormaEntrega { get; set; }

        protected Medio(string formaEntrega)
        {
            FormaEntrega = formaEntrega;
        }

        public abstract string MedioEntrega();

    }
}
