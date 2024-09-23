using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpresaInvoker empresa = new EmpresaInvoker();

            ProductReceiver leche = new ProductReceiver("Leche", 10);
            ProductReceiver cereales = new ProductReceiver("Cereales", 10);

            OrdenCommand comandAlta = new AltaStockCommand(leche, 4);
            OrdenCommand comandBaja = new BajaStockCommand(cereales, 4);

            empresa.AgregarCommand(comandAlta);
            empresa.AgregarCommand(comandBaja);

            Console.WriteLine(leche.Cantidad);
            Console.WriteLine(cereales.Cantidad);

            empresa.Procesar();

            Console.WriteLine(leche.Cantidad);
            Console.WriteLine(cereales.Cantidad);


            Console.ReadKey();
        }
    }
}
