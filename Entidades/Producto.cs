using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int CantidadStock { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public string Categoria { get; set; }

        public void ActualizarStock(int cantidad)
        {
            CantidadStock += cantidad;
        }

        public bool ValidarDisponibilidad(int cantidadRequerida)
        {
            return CantidadStock >= cantidadRequerida;
        }

        public decimal CalcularMargenGanancia()
        {
            return PrecioVenta - PrecioCompra;
        }

        public void CambiarPrecioVenta(decimal nuevoPrecio)
        {
            PrecioVenta = nuevoPrecio;
        }

    }
}
