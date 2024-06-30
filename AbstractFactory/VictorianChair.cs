using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VictorianChair : IChair
    {
        public string Model { get; set; } = "Victorian";

        public bool HasLegs()
        {
            return true;
        }

        public void SitOn()
        {
            Console.WriteLine("Te sentaste");
        }
    }
}
