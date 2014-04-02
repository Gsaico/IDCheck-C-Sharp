using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IDCheck.Modelo
{
    class Servidor_BD
    {
        public Controlador.Servidor FechayHoradelServidor()
        {

            Controlador.Servidor clsServidorx = new Controlador.Servidor();
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand("select NOW() as Fechitayhora", cnx);


            

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsServidorx.datetimeservidor = Convert.ToString(reader["Fechitayhora"]);
               

            }
            cnx.Close();
            return clsServidorx;
        }

    }
}
