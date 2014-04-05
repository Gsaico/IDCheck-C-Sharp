using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDCheck.Modelo
{
    class Area_BD
    {


        public DataTable CargarArea()
        {


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            DataTable dt = new DataTable();

            SqlCommand comando = new SqlCommand(
           "SELECT idArea, NombreArea FROM area", cnx);
            comando.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);
            cnx.Close();
            return dt;



        }

        public static int AgregarNuevaArea(Controlador.Area clsArea)
        {

            int retorno = 0;
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO area(idArea, NombreArea) VALUES('{0}','{1}')",
             clsArea.idarea, clsArea.nombrearea), cnx);

            retorno = comando.ExecuteNonQuery();

            cnx.Close();
            return retorno;
        }


        public bool VerificarSiExisteArea(string NombreArea)
        {


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM area WHERE NombreArea='{0}'", NombreArea), cnx);

            SqlDataReader reader = comando.ExecuteReader();

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


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(
           "SELECT TOP (1) * FROM area order by idArea desc", cnx);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["idArea"]);


            }
            cnx.Close();
            return id;
        }

    }
}
