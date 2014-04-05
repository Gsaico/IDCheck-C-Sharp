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

        public static int AgregarNuevaArea(Controlador.Area clsArea)
        {

            int retorno = 0;
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO area(idArea, NombreArea) VALUES('{0}','{1}')",
             clsArea.idarea , clsArea.nombrearea), cnx);

            retorno = comando.ExecuteNonQuery();

            cnx.Close();
            return retorno;
        }


        public bool VerificarSiExisteArea(string NombreArea)
        {


            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM area WHERE NombreArea='{0}'", NombreArea), cnx);

            MySqlDataReader reader = comando.ExecuteReader();

            reader.Read();
            Boolean existeusuario = reader.HasRows;

            cnx.Close();

            if (existeusuario == true)
            {

                return true;
            }

            else
            {

                return false;
            }



        }
        public int UltimoIDdeArea()
        {
            int id = 0;


            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(
           "SELECT * FROM area order by idArea desc  limit 1", cnx);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["idArea"]);


            }
            cnx.Close();
            return id;
        }

    }
}
