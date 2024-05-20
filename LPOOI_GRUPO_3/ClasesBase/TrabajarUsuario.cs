using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    class TrabajarUsuario
    {
        public static DataTable list_roles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta sql
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la tabla
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
