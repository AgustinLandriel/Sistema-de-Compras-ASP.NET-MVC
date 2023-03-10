using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int IdProducto { get; set; }

        public string Descripcion { get; set; }
        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public string UrlImagen { get; set; }

        public string NombreImagen { get; set; }

        public bool Activo { get; set; }

    }

}
