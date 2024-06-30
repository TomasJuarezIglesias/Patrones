using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MotorElectricoAdapter : IMotor
    {
        MotorElectrico motorElectrico;

        public MotorElectricoAdapter()
        {
            motorElectrico = new MotorElectrico();
        }

        public void CargarCombustible()
        {
            motorElectrico.Enchufar();
        }
    }
}
