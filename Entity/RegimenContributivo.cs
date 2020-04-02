using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegimenContributivo : Liquidacion
    {


        public override void CalcularTarifa()
        {

            if (Salario < 2 * SMMLV)
            {
                Tarifa = 0.15;
                Tope = 250000;
            }
            if (Salario >= 2 * SMMLV && Salario <= 5 * SMMLV) 
            {
                Tarifa = 0.20;
                Tope = 900000;
            }
            else
            {
                Tarifa = 0.25;
                Tope = 1500000;
            }
        }

    }
}
