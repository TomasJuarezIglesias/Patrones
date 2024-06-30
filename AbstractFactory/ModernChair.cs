using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ModernChair : IChair
    {
        public string Model { get; set; } = "Modern";

        public bool HasLegs()
        {
            return false;
        }

        public void SitOn()
        {
            Console.WriteLine("Te sentaste");
        }
    }
}
