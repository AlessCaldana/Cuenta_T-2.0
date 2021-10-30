using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Contabilizacion : Usuario
    {
        public Contabilizacion()
        {
            Debe = 0;
            Haber = 0;
            Saldo = 0;

        }
        public string Id { get; set; }
        public string CodigoCuenta { get; set; }
        public string Detalle { get; set; }
        public double Debe { get; set; }
        public double Haber{ get; set; }
        public double Saldo { get; set; }
        public double SumatoriaDebe { get; set; }
        public double SumatoriaHaber { get; set; }
        public DateTime fechaRegistroContable { get; set; }

        private void CalcularSaldo()
        {
            Saldo = Debe - Haber;
        }

        private void CalcularSumatoriaDebe()
        {
            SumatoriaDebe = SumatoriaDebe + Debe;
        }

        private void CalcularSumatoriaHaber()
        {
            SumatoriaHaber = SumatoriaHaber + Haber;
        }

    }
}
