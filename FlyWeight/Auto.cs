using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class Auto : IFlyWeight
    {
        public string Modelo { get; set; }

        public Auto(string modelo)
        {
            Modelo = modelo;
        }

        public string ObtenerNombre()
        {
            return Modelo;
        }
    }
}
