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

        public static int AgregarNuevoTipodePersonal(Controlador.TipoPersonal clsTipoPersonal)
        {

            int retorno = 0;
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO tipopersonal(idTipoPersonal, NombreTipoPersonal) VALUES('{0}','{1}')",
             clsTipoPersonal.tipoPersonal, clsTipoPersonal.nombreTipoPersonal), cnx);

            retorno = comando.ExecuteNonQuery();

            cnx.Close();
            return retorno;
        }


        public bool VerificarSiExisteelTipodePersonal(string NombreTipoPersonal)
        {


            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM tipopersonal WHERE NombreTipoPersonal='{0}'", NombreTipoPersonal), cnx);

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
        public int UltimoIDdeTipoPersonal()
        {
            int id=0;

           
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(
           "SELECT * FROM tipopersonal order by idTipoPersonal desc  limit 1", cnx);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["idTipoPersonal"]);
               

            }
            cnx.Close();
            return id;
        }

    }
}
