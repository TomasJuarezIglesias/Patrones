using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class Template
    {


        public void TemplateMethod()
        {
            Console.WriteLine("Ejecuto metodo 1");
            Method1();

            Console.WriteLine("Ejecuto metodo 2");
            Method2();
        }

        public abstract void Method1();
        public abstract void Method2();


    }
}
