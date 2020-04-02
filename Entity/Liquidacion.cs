using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Liquidacion
    {
        public string NumeroLiquidacion { get; set; }

        public string Identificacion { get; set; }

        public string TipoAfilicacion { get; set; }

        public double Salario { get; set; }

        public double CuotaModeradora { get; set; }

        public double Tarifa { get; set; }

        public double Tope { get; set; }

        public double ValorServicio { get; set; }

        public double SMMLV = 877.803;

        public abstract void CalcularTarifa();

        public double CalcularCuotaModeradora() 
        {

            return CuotaModeradora = ValorServicio * Tarifa;

        }

    }
}
