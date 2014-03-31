using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IDCheck.Conexion
{
    class Conexion
    {


        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=id_check_db; Uid=root; pwd=12345;");

            conectar.Open();
            return conectar;
        }
    }
}
