using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Transaccion
    {
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        public abstract void Registrar();
        public DateTime ConsultarFecha()
        {
            return Fecha;
        }
    }
}
