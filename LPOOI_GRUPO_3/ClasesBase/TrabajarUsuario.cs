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

        public static DataRow Buscar(string nombreUsuario, string contrasenia)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE NombreUsuario=@usuario AND Contrasenia=@contra";
            cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contra", contrasenia);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Select().Length==1) {
                return dt.Select().First();
            } else {
                return null;
            }
            
        }

        public static bool Autenticar(string nombreUsuario, string contrasenia)
        {
            DataRow dr = Buscar(nombreUsuario, contrasenia);
            if (dr!=null) {
                return true;
            } else {
                return false;
            }
        }

        public static Usuario ToUsuario(DataRow dr)
        {
            Usuario oUsuario = new Usuario();
            oUsuario.Usu_ID = (int) dr["ID"];
            oUsuario.Usu_NombreUsuario = (string) dr["NombreUsuario"];
            oUsuario.Usu_Contrasenia = (string) dr["Contrasenia"];
            oUsuario.Usu_ApellidoNombre = (string) dr["ApellidoNombre"];
            oUsuario.Rol_Codigo = (int) dr["Rol_Codigo"];
            return oUsuario;
        }
    }
}
