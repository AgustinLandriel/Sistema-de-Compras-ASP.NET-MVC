using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class CD_Usuarios
    {

        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                SqlConnection conexion = new SqlConnection(AccesoDatos.conexion);

                string consulta = "SELECT IdUsuario,Nombres,Apellidos,Correo,Clave,Reestablecer,Activo FROM USUARIOS";

                SqlCommand comando = new SqlCommand(consulta,conexion);

                comando.CommandType = CommandType.Text;

                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
                


                while (lector.Read())
                {
                    Usuario usuario = new Usuario();

                    usuario.IdUsuario = (int)lector["IdUsuario"];
                    usuario.Nombre = (string)lector["Nombres"].ToString();
                    usuario.Apellido = (string)lector["Apellidos"].ToString();
                    usuario.Correo = (string)lector["Correo"].ToString();
                    usuario.Clave = (string)lector["Clave"].ToString();
                    usuario.Reestablecer = (bool)lector["Apellidos"];
                    usuario.Activo = (bool)lector["Apellidos"];


                    lista.Add(usuario);

                }


                return lista;
            }
            catch (Exception)
            {

                throw;
            }
           
             
            
        }
    }
}
