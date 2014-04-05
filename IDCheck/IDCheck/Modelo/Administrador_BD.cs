using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDCheck.Modelo
{
    class Administrador_BD
    {
        public Controlador.Administrador BuscarAdministradorXdni(Controlador.Administrador clsAdministrador)
        {
            Controlador.Administrador clsAdministradorx = new Controlador.Administrador();
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(String.Format(
           "SELECT Pasword, idPersonal FROM administrador WHERE idPersonal='{0}'", clsAdministrador.idpersonal), cnx);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsAdministradorx.pasword = Convert.ToString(reader["Pasword"]);
                clsAdministradorx.idpersonal = Convert.ToString(reader["idPersonal"]);


            }
            cnx.Close();
            return clsAdministradorx;
        }


        public static int AgregarDatosdAdministrador(Controlador.Administrador clsAdministrador)
        {

            int retorno = 0;
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO administrador(Pasword, idPersonal) VALUES('{0}','{1}')",
            clsAdministrador.pasword, clsAdministrador.idpersonal), cnx);

            retorno = comando.ExecuteNonQuery();

            cnx.Close();
            return retorno;
        }

        public static int ActualizarDatosdAdministrador(Controlador.Administrador clsAdministrador)
        {
            int retorno = 0;
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("Update administrador set Pasword='{0}' where idPersonal={1}",
                clsAdministrador.pasword, clsAdministrador.idpersonal), cnx);

            retorno = comando.ExecuteNonQuery();
            cnx.Close();

            return retorno;

        }

        public bool VerificarSiExisteAdministrador(string dni)
        {


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM administrador WHERE idPersonal='{0}'", dni), cnx);

            SqlDataReader reader = comando.ExecuteReader();

            reader.Read();
            Boolean existeAdministrador = reader.HasRows;

            cnx.Close();

            if (existeAdministrador == true)
            {

                return true;
            }

            else
            {

                return false;
            }



        }
    }
}
