using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class FlyWeightFactory
    {
        private List<IFlyWeight>  FlyWeights { get; set; }

        public FlyWeightFactory()
        {
            FlyWeights = new List<IFlyWeight>();
        }

        public IFlyWeight GetAuto(string modelo)
        {
            IFlyWeight flyWeight = FlyWeights.FirstOrDefault(f => f.ObtenerNombre() == modelo);

            if (flyWeight is null) 
            {
                flyWeight = new Auto(modelo);

                FlyWeights.Add(flyWeight);
            }

            return flyWeight;
        }

        public int CantidadInstancias()
        {
            return FlyWeights.Count;
        }
    }
}
