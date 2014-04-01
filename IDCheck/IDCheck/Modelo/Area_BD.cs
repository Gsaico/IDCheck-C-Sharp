using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IDCheck.Modelo
{
    class Area_BD
    {


        public DataTable CargarArea()
        {


            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            DataTable dt = new DataTable();

            MySqlCommand comando = new MySqlCommand(
           "SELECT idArea, NombreArea FROM area", cnx);
            comando.ExecuteNonQuery();
                        
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            adap.Fill(dt);
            cnx.Close();
            return dt;

            

        }

    }
}
