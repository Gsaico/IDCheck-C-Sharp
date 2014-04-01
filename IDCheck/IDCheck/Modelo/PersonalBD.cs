using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IDCheck.Modelo
{
   class PersonalBD
    {

        public  Controlador.Personal BuscarPersonalXdni(Controlador.Personal clsPersonal)
        {

            Controlador.Personal clsPersonalx = new Controlador.Personal();
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format(
           "SELECT idPersonal, Nombres, Apellidos, FechaNac, Foto, Cargo FROM personal WHERE idPersonal='{0}'", clsPersonal.idpersonal), cnx);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsPersonalx.idpersonal = Convert.ToString(reader["idPersonal"]);
                clsPersonalx.nombres = Convert.ToString(reader["Nombres"]);
                clsPersonalx.apellidos = Convert.ToString(reader["Apellidos"]);
                clsPersonalx.fechanac = Convert.ToString(reader["FechaNac"]);
                clsPersonalx.foto = (byte[])reader["Foto"];
                clsPersonalx.cargo = Convert.ToString(reader["Cargo"]);
                 
            }
            cnx.Close();
            return clsPersonalx;
        }


        public static int AgregarDatosdPersonal(Controlador.Personal clsPersonal)
        {

            int retorno = 0;
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO personal(idPersonal,Nombres,Apellidos,FechaNac,Foto,Cargo) VALUES('{0}','{1}','{2}', '{3}','{4}','{5}')",
            clsPersonal.idpersonal, clsPersonal.nombres, clsPersonal.apellidos, clsPersonal.fechanac, clsPersonal.foto, clsPersonal.cargo), cnx);

            retorno = comando.ExecuteNonQuery();

            cnx.Close();
            return retorno;
        }

        public static int ActualizarDatosdPersonal(Controlador.Personal clsPersonal)
        {
            int retorno = 0;
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update personal set Nombres='{0}', Apellidos='{1}', FechaNac='{2}', Foto='{3}', Cargo='{4}' where idPersonal={5}",
               clsPersonal.nombres, clsPersonal.apellidos, clsPersonal.fechanac, clsPersonal.foto, clsPersonal.cargo, clsPersonal.idpersonal), cnx);

            retorno = comando.ExecuteNonQuery();
            cnx.Close();

            return retorno;

        }

        public bool VerificarSiExistePersonal(string dni)
        {


            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM personal WHERE idPersonal='{0}'", dni), cnx);

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
