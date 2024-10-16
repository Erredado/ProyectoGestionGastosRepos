using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteFinanciero
    {
        public int IdReporte { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public decimal TotalIngresos { get; set; }
        public decimal TotalGastos { get; set; }
        public decimal BeneficioNeto { get; set; }

        public void GenerarReporteFinanciero(DateTime fechaInicio, DateTime fechaFin)
        {
            Console.WriteLine("Reporte financiero generado.");
        }

        public decimal CalcularBeneficioNeto()
        {
            return TotalIngresos - TotalGastos;
        }

        public void MostrarEstadisticas()
        {
            Console.WriteLine("Mostrando estadísticas.");
        }

        public string ExportarReporte(string formato)
        {
            return $"Reporte exportado en formato {formato}.";
        }

    }
}
