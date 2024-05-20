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

        public static DataTable Listar()
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT R.Descripcion as 'Rol', ";
            cmd.CommandText += "U.ApellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += "U.NombreUsuario as 'Usuario', ";
            cmd.CommandText += "U.Contrasenia as 'Contraseña', ";
            cmd.CommandText += "U.ID as 'ID Usuario', ";
            cmd.CommandText += "U.Rol_Codigo as 'Codigo Rol' ";
            cmd.CommandText += "FROM Usuario as U ";
            cmd.CommandText += "LEFT JOIN Roles as R ON (R.Codigo=U.Rol_Codigo) ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void Insertar(Usuario u)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario (NombreUsuario, Contrasenia, ApellidoNombre, Rol_Codigo) ";
            cmd.CommandText += "VALUES (@nomUsu, @contra, @apeNom, @rolCod)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@nomUsu", u.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contra", u.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@apeNom", u.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("rolCod", u.Rol_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable Buscar(string patron)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Rol_Codigo as 'Rol', ";
            cmd.CommandText += "ApellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += "NombreUsuario as 'Usuario', ";
            cmd.CommandText += "Contrasenia as 'Contraseña', ";
            cmd.CommandText += "U.ID as 'ID Usuario', ";
            cmd.CommandText += "U.Rol_Codigo as 'Codigo Rol' ";
            cmd.CommandText += "FROM Usuario as U ";
            cmd.CommandText += "LEFT JOIN Roles as R ON (R.Codigo=U.Rol_Codigo) ";

            cmd.CommandText += "WHERE U.ApellidoNombre LIKE @patron ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@patron", "%"+patron+"%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool Autenticar(string nombreUsuario, string contrasenia)
        {
            DataRow dr = BuscarSingular(nombreUsuario, contrasenia);
            if (dr!=null) {
                return true;
            } else {
                return false;
            }
        }

        public static DataRow BuscarSingular(string nombreUsuario, string contrasenia)
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

        public static DataTable ListarRoles()
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
