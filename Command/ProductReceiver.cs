using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class ProductReceiver
    {
        public string Nombre { get; set; }
        public double Cantidad { get; set; }

        public ProductReceiver(string nombre, double cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

        public void SumarStock(double cantidad)
        {
            Cantidad += cantidad;
        }

        public void RestarStock(double cantidad)
        {
            Cantidad -= cantidad;
        }
    }
}
