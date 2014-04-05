using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDCheck.Modelo
{
    class Servidor_BD
    {
        public Controlador.Servidor FechayHoradelServidor()
        {

            Controlador.Servidor clsServidorx = new Controlador.Servidor();
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand("select GETDATE() AS Fechitayhora", cnx);


            

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsServidorx.datetimeservidor = Convert.ToDateTime(reader["Fechitayhora"]);
               

            }
            cnx.Close();
            return clsServidorx;
        }

    }
}
