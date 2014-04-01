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

            MySqlCommand comando = new MySqlCommand("select now() as Fechitayhora", cnx);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsServidorx.datetimeservidor = Convert.ToDateTime(reader["Fechitayhora"]);
               

            }
            cnx.Close();
            return clsServidorx;
        }

    }
}
