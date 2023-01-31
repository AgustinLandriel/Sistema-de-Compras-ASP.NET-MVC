using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Carrito
    {
        public Carrito IdCarrito { get; set; }

        public Cliente IdCliente { get; set; }

        public Producto IdProducto { get; set; }

        public int  Cantidad { get; set; }

    }
}
