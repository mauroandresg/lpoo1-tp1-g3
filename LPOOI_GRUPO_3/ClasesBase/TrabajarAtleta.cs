using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public static class TrabajarAtleta
    {
        private static string connectionString = ClasesBase.Properties.Settings.Default.competenciaConnectionString;

        // LISTAR
        public static DataTable listarAtleta()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT " +
                                  "atl_id AS 'Id', " +
                                  "atl_dni AS 'DNI', " +
                                  "atl_apellido AS 'Apellido', " +
                                  "atl_nombre AS 'Nombre', " +
                                  "atl_nacionalidad AS 'Nacionalidad', " +
                                  "atl_entrenador AS 'Entrenador', " +
                                  "atl_genero AS 'Genero', " +
                                  "atl_altura AS 'Altura', " +
                                  "atl_peso AS 'Peso', " +
                                  "atl_fechaNac AS 'Fecha Nac', " +
                                  "atl_direccion AS 'Direccion', " +
                                  "atl_email AS 'Email' " +
                                  "FROM Atleta";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // GUARDAR
        public static void guardarAtleta(Atleta atleta)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Atleta(atl_dni, atl_apellido, atl_nombre, atl_nacionalidad, atl_entrenador, atl_genero, atl_altura, atl_peso, atl_fechaNac, atl_direccion, atl_email) " +
                                  "VALUES (@dni, @apellido, @nombre, @nacionalidad, @entrenador, @genero, @altura, @peso, @fechaNac, @direccion, @email)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@dni", atleta.Atl_dni);
                cmd.Parameters.AddWithValue("@apellido", atleta.Atl_apellido);
                cmd.Parameters.AddWithValue("@nombre", atleta.Atl_nombre);
                cmd.Parameters.AddWithValue("@nacionalidad", atleta.Atl_nacionalidad);
                cmd.Parameters.AddWithValue("@entrenador", atleta.Atl_entrenador);
                cmd.Parameters.AddWithValue("@genero", atleta.Atl_genero);
                cmd.Parameters.AddWithValue("@altura", atleta.Atl_altura);
                cmd.Parameters.AddWithValue("@peso", atleta.Atl_peso);
                cmd.Parameters.AddWithValue("@fechaNac", atleta.Atl_fechaNac);
                cmd.Parameters.AddWithValue("@direccion", atleta.Atl_direccion);
                cmd.Parameters.AddWithValue("@email", atleta.Atl_email);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        // BUSCAR
        public static DataTable buscarAtleta(string sPattern)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT " +
                                  "atl_id AS 'Id Atleta', " +
                                  "atl_dni AS 'DNI', " +
                                  "atl_apellido AS 'Apellido', " +
                                  "atl_nombre AS 'Nombre', " +
                                  "atl_nacionalidad AS 'Nacionalidad', " +
                                  "atl_entrenador AS 'Entrenador', " +
                                  "atl_genero AS 'Genero', " +
                                  "atl_altura AS 'Altura', " +
                                  "atl_peso AS 'Peso', " +
                                  "atl_fechaNac AS 'Fecha Nac', " +
                                  "atl_direccion AS 'Direccion', " +
                                  "atl_email AS 'Email' " +
                                  "FROM Atleta " +
                                  "WHERE atl_nombre LIKE @pattern";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // ELIMINAR
        public static void eliminarAtleta(int id)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM Atleta WHERE atl_id = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@id", id);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        // MODIFICAR
        public static void modificarAtleta(Atleta atleta)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE Atleta SET " +
                                  "atl_dni = @dni, " +
                                  "atl_apellido = @apellido, " +
                                  "atl_nombre = @nombre, " +
                                  "atl_nacionalidad = @nacionalidad, " +
                                  "atl_entrenador = @entrenador, " +
                                  "atl_genero = @genero, " +
                                  "atl_altura = @altura, " +
                                  "atl_peso = @peso, " +
                                  "atl_fechaNac = @fechaNac, " +
                                  "atl_direccion = @direccion, " +
                                  "atl_email = @email " +
                                  "WHERE atl_id = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@id", atleta.Atl_id);
                cmd.Parameters.AddWithValue("@dni", atleta.Atl_dni);
                cmd.Parameters.AddWithValue("@apellido", atleta.Atl_apellido);
                cmd.Parameters.AddWithValue("@nombre", atleta.Atl_nombre);
                cmd.Parameters.AddWithValue("@nacionalidad", atleta.Atl_nacionalidad);
                cmd.Parameters.AddWithValue("@entrenador", atleta.Atl_entrenador);
                cmd.Parameters.AddWithValue("@genero", atleta.Atl_genero);
                cmd.Parameters.AddWithValue("@altura", atleta.Atl_altura);
                cmd.Parameters.AddWithValue("@peso", atleta.Atl_peso);
                cmd.Parameters.AddWithValue("@fechaNac", atleta.Atl_fechaNac);
                cmd.Parameters.AddWithValue("@direccion", atleta.Atl_direccion);
                cmd.Parameters.AddWithValue("@email", atleta.Atl_email);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }

}
