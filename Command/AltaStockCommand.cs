using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class AltaStockCommand : OrdenCommand
    {
        public AltaStockCommand(ProductReceiver productReceiver, double cantidad) : base(productReceiver, cantidad)
        {
        }

        public override void Execute()
        {
            _producto.SumarStock(_cantidad); 
        }
    }
}
