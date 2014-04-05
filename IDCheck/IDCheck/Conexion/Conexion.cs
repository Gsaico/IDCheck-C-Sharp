using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDCheck.Properties;
using System.Configuration;
namespace IDCheck.Conexion
{
    class Conexion
    {

        public static string CadenadeConexionSystema() {

            return Settings.Default.id_check_dbConnectionString2; 
        
        }
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conectar = new SqlConnection(CadenadeConexionSystema());

            //@"Server=PERVAC-PC\MSSQLSERVERX;database=id_check_db;integrated security=true"
            

           
            return conectar;
        }


    }
}
