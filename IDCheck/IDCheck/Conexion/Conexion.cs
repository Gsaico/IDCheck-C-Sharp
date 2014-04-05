using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDCheck.Conexion
{
    class Conexion
    {


        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conectar = new SqlConnection(@"Server=PERVAC-PC\MSSQLSERVERX;database=id_check_db;integrated security=true");


            

           
            return conectar;
        }
    }
}
