using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDCheck.Modelo
{
    class EmpresaColaboradora_BD
    {

        public Controlador.EmpresaColaboradora BuscarXRUC(Controlador.EmpresaColaboradora clsEmpresaColaboradora)
        {

            Controlador.EmpresaColaboradora clsEmpresaColaboradorax = new Controlador.EmpresaColaboradora();
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(String.Format(
           "SELECT NombreEmpresa, Gerente, Telefono, Email, idEmpresaColaboradora FROM empresacolaboradora WHERE idEmpresaColaboradora='{0}'", clsEmpresaColaboradora.idEmpresaColaboradora), cnx);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsEmpresaColaboradorax.email = Convert.ToString(reader["Email"]);
                clsEmpresaColaboradorax.gerente = Convert.ToString(reader["Gerente"]);
                clsEmpresaColaboradorax.idEmpresaColaboradora = Convert.ToString(reader["idEmpresaColaboradora"]);
                clsEmpresaColaboradorax.nombreEmpresa = Convert.ToString(reader["NombreEmpresa"]);
                clsEmpresaColaboradorax.telefono = Convert.ToString(reader["Telefono"]);


            }
            cnx.Close();
            return clsEmpresaColaboradorax;
        }


        public bool VerificarSiExisteRUC(string ruc)
        {


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM empresacolaboradora WHERE idEmpresaColaboradora='{0}'", ruc), cnx);

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

        public static int AgregarEmpresa(Controlador.EmpresaColaboradora clsEmpresaColaboradora)
        {

            int retorno = 0;
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO empresacolaboradora(NombreEmpresa, Gerente, Telefono, Email, idEmpresaColaboradora) VALUES('{0}','{1}','{2}', '{3}','{4}')",
            clsEmpresaColaboradora.nombreEmpresa, clsEmpresaColaboradora.gerente, clsEmpresaColaboradora.telefono, clsEmpresaColaboradora.email, clsEmpresaColaboradora.idEmpresaColaboradora), cnx);

            retorno = comando.ExecuteNonQuery();

            cnx.Close();
            return retorno;
        }

        public static int ActualizarDatosdEmpresa(Controlador.EmpresaColaboradora clsEmpresaColaboradora)
        {
            int retorno = 0;
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("Update empresacolaboradora set NombreEmpresa='{0}', Gerente='{1}', Telefono='{2}', Email='{3}' where idEmpresaColaboradora={4}",
                clsEmpresaColaboradora.nombreEmpresa, clsEmpresaColaboradora.gerente, clsEmpresaColaboradora.telefono, clsEmpresaColaboradora.email, clsEmpresaColaboradora.idEmpresaColaboradora), cnx);

            retorno = comando.ExecuteNonQuery();
            cnx.Close();

            return retorno;

        }

    }
}
