using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDCheck.Modelo
{
    class TipoPersonal_BD
    {

        public DataTable CargarTipopersonal()
        {


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            DataTable dt = new DataTable();

            SqlCommand comando = new SqlCommand(
           "SELECT idTipoPersonal, NombreTipoPersonal FROM tipopersonal", cnx);
            comando.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);
            cnx.Close();
            return dt;



        }

        public static int AgregarNuevoTipodePersonal(Controlador.TipoPersonal clsTipoPersonal)
        {

            int retorno = 0;
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO tipopersonal(idTipoPersonal, NombreTipoPersonal) VALUES('{0}','{1}')",
             clsTipoPersonal.tipoPersonal, clsTipoPersonal.nombreTipoPersonal), cnx);

            retorno = comando.ExecuteNonQuery();

            cnx.Close();
            return retorno;
        }


        public bool VerificarSiExisteelTipodePersonal(string NombreTipoPersonal)
        {


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM tipopersonal WHERE NombreTipoPersonal='{0}'", NombreTipoPersonal), cnx);

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
        public int UltimoIDdeTipoPersonal()
        {
            int id = 0;


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(
           "SELECT TOP(1) * FROM tipopersonal order by idTipoPersonal desc ", cnx);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["idTipoPersonal"]);


            }
            cnx.Close();
            return id;
        }

    }
}