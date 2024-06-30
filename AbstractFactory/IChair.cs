using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IChair
    {
        string Model { get; set; }

        bool HasLegs();
        void SitOn();
    }
}
