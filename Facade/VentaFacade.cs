using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class VentaFacade
    {
        private readonly Producto _producto;
        private readonly Cliente _cliente;

        public VentaFacade()
        {
            _producto = new Producto();
            _cliente = new Cliente();
        }

        public bool RegistrarVenta(string producto, string cliente)
        {

            _producto.CheckStock();

            _cliente.IsRegister();

            return true;
        }
    }
}
