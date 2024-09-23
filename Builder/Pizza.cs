using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {
        public Masa Masa { get; set; }

        public Pizza(Masa masa)
        {
            Masa = masa;
        }
    }
}
