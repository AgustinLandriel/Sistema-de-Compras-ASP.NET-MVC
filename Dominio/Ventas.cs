using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ventas

    {

        public int IdVenta { get; set; }
        public int IdCliente { get; set; }

        public int TotalProducto { get; set; }

        public decimal MontoTotal { get; set; }

        public string Contacto { get; set; }

        public int IdProvincia { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public List<DetalleVenta> DetalleVenta { get; set; }
        public string IdTransaccion { get; set; }
    }
}
