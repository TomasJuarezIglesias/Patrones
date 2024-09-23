using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class ConcreteClass : Template
    {
        public override void Method1()
        {
            Console.WriteLine("Implementacion metodo 1");
        }

        public override void Method2()
        {
            Console.WriteLine("Implementacion metodo 2");
        }
    }
}
