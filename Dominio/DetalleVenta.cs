using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }

        public int IdVentas { get; set; }

        public Producto IdProducto { get; set; }

        public int Cantidad { get; set; }

        public decimal Total { get; set; }

        public string IdTransaccion { get; set; }


    }
}
