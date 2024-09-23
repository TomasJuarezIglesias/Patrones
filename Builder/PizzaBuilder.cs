using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal abstract class PizzaBuilder
    {

        public Pizza BuildPizza()
        {
            Masa masa = new Masa();

            return new Pizza(masa);
        }

        public abstract Masa BuildMasa();


    }
}
