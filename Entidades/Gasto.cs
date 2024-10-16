using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gasto : Transaccion
    {
        public int IdGasto { get; set; }
        public string TipoGasto { get; set; }
        public string Descripcion { get; set; }

        public override void Registrar()
        {
            Console.WriteLine("Gasto registrado.");
        }

        public List<Gasto> ConsultarGastos(DateTime fechaInicio, DateTime fechaFin)
        {
            return new List<Gasto>();
        }

        public decimal CalcularGastosTotales(DateTime fechaInicio, DateTime fechaFin)
        {
            return 0; 
        }

    }
}
