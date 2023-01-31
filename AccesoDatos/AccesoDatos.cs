using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AccesoDatos
{
    public class AccesoDatos
    {
        public static string conexion = ConfigurationManager.ConnectionStrings["cadena"].ToString();

    }
}
