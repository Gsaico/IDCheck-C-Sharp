using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IDCheck.Modelo
{
    class TipoPersonal_BD
    {

        public DataTable CargarTipopersonal()
        {


            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            DataTable dt = new DataTable();

            MySqlCommand comando = new MySqlCommand(
           "SELECT idTipoPersonal, NombreTipoPersonal FROM tipopersonal", cnx);
            comando.ExecuteNonQuery();

            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            adap.Fill(dt);
            cnx.Close();
            return dt;



        }
    }
}
