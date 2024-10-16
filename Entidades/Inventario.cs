using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public List<Producto> Productos { get; set; }
        public int NivelReposicion { get; set; }

        public void ActualizarInventario(Producto producto, int cantidad)
        {
            var prod = Productos.FirstOrDefault(p => p.IdProducto == producto.IdProducto);
            if (prod != null)
            {
                prod.ActualizarStock(cantidad);
            }
        }

        public List<Producto> ConsultarProductosBajoStock()
        {
            return Productos.Where(p => p.CantidadStock < NivelReposicion).ToList();
        }

        public void GenerarAlertaReposicion(Producto producto)
        {
            if (producto.CantidadStock < NivelReposicion)
            {
                Console.WriteLine("Alerta: Stock bajo.");
            }
        }

        public void AgregarProducto(Producto nuevoProducto)
        {
            Productos.Add(nuevoProducto);
        }

    }
}
