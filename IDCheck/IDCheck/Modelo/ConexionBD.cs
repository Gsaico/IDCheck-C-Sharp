using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDCheck.Modelo
{
    class ConexionBD
    {

        public bool VerificarUsuario(string dni, string pasword)
        {


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();

            SqlCommand comando = new SqlCommand(string.Format("select * from administrador  where idPersonal='{0}'and Pasword='{1}'", dni, pasword), cnx);

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

        public bool ExistenUsuariosAdministradores()
        {


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();

            SqlCommand comando = new SqlCommand("select * from administrador", cnx);

            SqlDataReader reader = comando.ExecuteReader();

            reader.Read();
            Boolean existenusuarios = reader.HasRows;

            cnx.Close();

            if (existenusuarios == true)
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

