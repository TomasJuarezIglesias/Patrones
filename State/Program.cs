using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch swt = new Switch();

            swt.Presionar();

            swt.Presionar();

            swt.Presionar();

            swt.Presionar();

            Console.ReadKey();
        }
    }
}
