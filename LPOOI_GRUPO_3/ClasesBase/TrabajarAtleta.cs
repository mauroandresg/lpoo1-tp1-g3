using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarAtleta
    {
        //LISTAR
        public static DataTable listarAtleta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText += "SELECT ";
            cmd.CommandText += " atl_id as 'Id', ";
            cmd.CommandText += " atl_dni as 'DNI' ";
            cmd.CommandText += " atl_apellido as 'Apellido', ";
            cmd.CommandText += " atl_nombre as 'Nombre', ";
            cmd.CommandText += " atl_nacionalidad as 'Nacionalidad', ";
            cmd.CommandText += " atl_entrenador as 'Entrenador', ";
            cmd.CommandText += " atl_genero as 'Genero', ";
            cmd.CommandText += " atl_altura as 'Altura', ";
            cmd.CommandText += " atl_peso as 'Peso', ";
            cmd.CommandText += " atl_fechaNac as 'Fecha Nac', ";
            cmd.CommandText += " atl_direccion as 'Direccion', ";
            cmd.CommandText += " atl_email as 'Email'";
            cmd.CommandText += " FROM Atleta";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecutar la consola
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        //GUARDAR
        public static void guardarAtleta(Atleta atleta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Atleta(atl_dni, atl_apellid, atl_nombre, atl_nacionalidad, atl_entrenador, atl_genero, atl_altura, atl_peso, atl_fechaNac, atl_direccion, atl_email) VALUES (@dni,@apellido,@nombre,@nacionalidad, @entrenador, @genero, @altura, @peso, @fechaNac, @direccion, @email)";
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

        //BUSCAR
        public static DataTable buscarAtleta(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText += "SELECT ";
            cmd.CommandText += " atl_id as 'Id Atleta', atl_dni as 'DNI', ";
            cmd.CommandText += " atl_apellido as 'Apellido', atl_nombre as 'Nombre', ";
            cmd.CommandText += " atl_nacionalidad as 'Nacionalidad', atl_entrenador as 'Entrenador', ";
            cmd.CommandText += " atl_genero as 'Genero', atl_altura as 'Altura', atl_peso as 'Peso', ";
            cmd.CommandText += " atl_fechaNac as 'Fecha Nac', atl_direccion as 'Direccion', atl_email as 'Email'";
            cmd.CommandText += " FROM Atleta";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " atl_nombre LIKE @pattern";

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

        //ELIMINAR
        public static void eliminarAtleta(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Atleta WHERE atl_id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //MODIFICAR
        public static void modificarAtleta(Atleta atleta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.competenciaConnectionString);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Atleta SET atl_dni = @dni, atl_apellido = @apellido, atl_nombre = @nombre, atl_nacionalidad = @nacionalidad, atl_entrenador = @entrenador, atl_genero = @genero, atl_altura = @altura, atl_peso = @peso, atl_fechaNac = @fechaNac, atl_direccion = @direccion, atl_email = @email WHERE atl_id = @id";
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
}
