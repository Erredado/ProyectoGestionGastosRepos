using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta : Transaccion
    {
        public int IdVenta { get; set; }
        public List<Producto> ProductosVendidos { get; set; }
        public Usuario Vendedor { get; set; }
        public decimal Total { get; private set; }

        public override void Registrar()
        {
            Console.WriteLine("Venta registrada.");
        }

        public void CalcularTotal()
        {
            Total = ProductosVendidos.Sum(p => p.PrecioVenta);
        }

        public List<Venta> ConsultarVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            return new List<Venta>(); 
        }

        public string GenerarFactura()
        {
            return "Factura generada para la venta.";
        }

    }
}
