using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;


namespace Negocio
{
    public class CN_USUARIOS
    {
        private CD_Usuarios CD_Usuarios = new CD_Usuarios();


        public List<Usuario> ListarUsuarios()
        {
            return CD_Usuarios.Listar();
        }
        
    }
}
