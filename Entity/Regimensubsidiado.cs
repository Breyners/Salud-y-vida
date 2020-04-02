using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Regimensubsidiado:Liquidacion
    {
        public override void CalcularTarifa()
        {
            Tarifa = 0.05;
            Tope = 200000;
        }
    }
}
