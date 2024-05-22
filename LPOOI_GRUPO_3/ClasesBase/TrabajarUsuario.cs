using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        public static DataTable listRoles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consola
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena la consulta
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static Usuario ObtenerUsuario(string nombreUsuario, string contraseña)
        {
            Usuario usuario = null;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE usu_nombreUsuario = @nombreUsuario AND usu_contraseña = @contraseña";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                string pass = reader.GetString(2);
                string apellidoNombre = reader.GetString(3);
                int rolId = reader.GetInt32(4);
                usuario = new Usuario(id, nombre, pass, apellidoNombre, rolId);
            }

            cnn.Close();
            return usuario;
        }

        public static void insertarUsuario(Usuario user) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(rol_codigo,usu_nombreUsuario,usu_contraseña,usu_apellidoNombre) VALUES (@rol,@user,@pass,@nomYape)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", user.Rol_codigo);
            cmd.Parameters.AddWithValue("@user", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_contraseña);
            cmd.Parameters.AddWithValue("@nomYape", user.Usu_ApellidoNombre);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable listUsuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_descripcion as 'Rol', ";
            cmd.CommandText += " usu_apellidoNombre as 'Nombre y Apellido ', ";
            cmd.CommandText += " usu_nombreUsuario as 'Usuario', usu_contraseña as 'Contraseña'";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_id = U.rol_codigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecutar la consola
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarUsuario(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText += "SELECT ";
            cmd.CommandText += " usu_id as 'Usuario id', ";
            cmd.CommandText += " rol_descripcion as 'Rol', ";
            cmd.CommandText += " usu_apellidoNombre as 'Nombre y Apellido ', ";
            cmd.CommandText += " usu_nombreUsuario as 'Usuario', usu_contraseña as 'Contraseña'";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_id = U.rol_codigo)";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " usu_nombreUsuario LIKE @pattern";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            //Ejecutar la consola
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void eliminarUsuario(int usu_id)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM Usuario WHERE usu_id = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@id", usu_id);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void modificarUsuario(Usuario user)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE Usuario SET usu_nombreUsuario = @user, usu_contraseña = @pass, usu_apellidoNombre = @nomYape WHERE usu_id = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@user", user.Usu_NombreUsuario);
                cmd.Parameters.AddWithValue("@pass", user.Usu_contraseña);
                cmd.Parameters.AddWithValue("@nomYape", user.Usu_ApellidoNombre);
                cmd.Parameters.AddWithValue("@id", user.Usu_id);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}