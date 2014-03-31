using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IDCheck.Modelo
{
    class ConexionBD
    {

        public bool VerificarUsuario(string dni, string pasword)
        {


            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("select * from administrador  where idPersonal='{0}'and Pasword='{1}'", dni, pasword), cnx);
                       
            MySqlDataReader reader = comando.ExecuteReader();
                          
            reader.Read();
            Boolean existeusuario = reader.HasRows;

            cnx.Close();

            if (existeusuario == true)
            { 
                
                return true; 
               }
                
            else { 
                
                return false; }

            

        }
    }
}
