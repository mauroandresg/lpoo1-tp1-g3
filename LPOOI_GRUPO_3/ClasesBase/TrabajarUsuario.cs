using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        static string cadenaConexion = ClasesBase.Properties.Settings.Default.comdepConnectionString;

        /// <summary>
        /// Busca en la tabla Usuario y devuelve el registro que coincida en Nombre de Usuario y Contraseña 
        /// </summary>
        public static ComdepDataSet.UsuarioRow Buscar(string nombreUsuario, string contrasenia)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE NombreUsuario=@usuario AND Contrasenia=@contra";
            cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contra", contrasenia);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ComdepDataSet ds = new ComdepDataSet();
            da.Fill(ds, "Usuario");
            if (ds.Usuario.Count==0) {
                return null;
            } else {
                return ds.Usuario.First();
            }
        }

        /// <summary>
        /// Dado el Nombre de usuario y Contraseña, busca en la tabla Usuario y verifica que existan las credenciales.
        /// Si existe devuelve verdadero, de lo contrario devuelve falso.
        /// </summary>
        public static bool Autenticar(string nombreUsuario, string contrasenia)
        {
            ComdepDataSet.UsuarioRow buscado = Buscar(nombreUsuario, contrasenia);
            if (buscado != null) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Busca en la tabla Usuario y devuelve el registro que coincida en Nombre de Usuario y Contraseña.
        /// Además, carga los datos de las tablas relacionadas a Usuario: Roles
        /// </summary>
        public static ComdepDataSet.UsuarioRow BuscarExpandido(string nombreUsuario, string contrasenia)
        {
            ComdepDataSet ds = new ComdepDataSet();
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE NombreUsuario=@usuario AND Contrasenia=@contra";
            cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contra", contrasenia);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Usuario");
            da = new SqlDataAdapter("SELECT * FROM Roles", cnn);
            da.Fill(ds, "Roles");
            if (ds.Usuario.Count == 0) {
                return null;
            } else {
                return ds.Usuario.First();
            }
        }
    }
}
