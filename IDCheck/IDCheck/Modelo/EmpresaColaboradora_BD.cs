using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IDCheck.Modelo
{
    class EmpresaColaboradora_BD

    {

        public Controlador.EmpresaColaboradora BuscarXRUC(Controlador.EmpresaColaboradora clsEmpresaColaboradora)
        {

            Controlador.EmpresaColaboradora clsEmpresaColaboradorax = new Controlador.EmpresaColaboradora();
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format(
           "SELECT NombreEmpresa, Gerente, Telefono, Email, idEmpresaColaboradora FROM empresacolaboradora WHERE idEmpresaColaboradora='{0}'", clsEmpresaColaboradora.idEmpresaColaboradora), cnx);
            MySqlDataReader reader = comando.ExecuteReader();

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


            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM empresacolaboradora WHERE idEmpresaColaboradora='{0}'", ruc), cnx);

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
    }
}
