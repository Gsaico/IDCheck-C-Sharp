using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDCheck.Modelo
{
    class PersonalBD
    {

        public Controlador.Personal BuscarPersonalXdni(Controlador.Personal clsPersonal)
        {

            Controlador.Personal clsPersonalx = new Controlador.Personal();
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(String.Format(
           "SELECT idPersonal,Nombres,Apellidos,FechaNac,Foto,Cargo FROM personal WHERE idPersonal='{0}'", clsPersonal.idpersonal), cnx);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsPersonalx.idpersonal = Convert.ToString(reader["idPersonal"]);
                clsPersonalx.nombres = Convert.ToString(reader["Nombres"]);
                clsPersonalx.apellidos = Convert.ToString(reader["Apellidos"]);
                clsPersonalx.fechanac = Convert.ToDateTime(reader["FechaNac"]);
                clsPersonalx.foto = (byte[])reader["Foto"];
                clsPersonalx.cargo = Convert.ToString(reader["Cargo"]);

            }
            cnx.Close();
            return clsPersonalx;
        }


        //public static int AgregarDatosdPersonal(Controlador.Personal clsPersonal)
        //{

        //    int retorno = 0;
        //    SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
        //    cnx.Open();
        //    SqlCommand comando = new SqlCommand(string.Format("INSERT INTO personal(idPersonal,Nombres,Apellidos,FechaNac,Foto,Cargo) VALUES('{0}','{1}','{2}', '{3}','{4}','{5}')",
        //    clsPersonal.idpersonal, clsPersonal.nombres, clsPersonal.apellidos, clsPersonal.fechanac, clsPersonal.foto, clsPersonal.cargo), cnx);

        //    retorno = comando.ExecuteNonQuery();

        //    cnx.Close();
        //    return retorno;
        //}


        public static int InsertarDatosdelPersonal(Controlador.Personal clsPersonal)
        {

            int retorno = 0;
            
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            string query = "INSERT INTO personal(idPersonal,Nombres,Apellidos,FechaNac,Foto,Cargo) VALUES(@idPersonal,@Nombres,@Apellidos,@FechaNac,@Foto,@Cargo)";
            SqlCommand cmd = new SqlCommand(query, cnx);

            cmd.Parameters.AddWithValue("@idPersonal", clsPersonal.idpersonal);
            cmd.Parameters.AddWithValue("@Nombres", clsPersonal.nombres);
            cmd.Parameters.AddWithValue("@Apellidos", clsPersonal.apellidos);
            cmd.Parameters.AddWithValue("@FechaNac", clsPersonal.fechanac);
            cmd.Parameters.AddWithValue("@Cargo", clsPersonal.cargo);
            cmd.Parameters.Add("@Foto", System.Data.SqlDbType.Image).Value = clsPersonal.foto;
            cnx.Open();
         
                cmd.ExecuteNonQuery();

                cnx.Close();
                retorno = 1;
                return retorno;

            
        }


        public static int ActualizarDatosdelPersonal(Controlador.Personal clsPersonal)
        {
            int retorno = 0;

            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            string query = "Update personal set Nombres=@Nombres, Apellidos=@Apellidos, FechaNac=@FechaNac, Foto=@Foto, Cargo=@Cargo where idPersonal=@idPersonal";
            SqlCommand cmd = new SqlCommand(query, cnx);

            cmd.Parameters.AddWithValue("@idPersonal", clsPersonal.idpersonal);
            cmd.Parameters.AddWithValue("@Nombres", clsPersonal.nombres);
            cmd.Parameters.AddWithValue("@Apellidos", clsPersonal.apellidos);
            cmd.Parameters.AddWithValue("@FechaNac", clsPersonal.fechanac);
            cmd.Parameters.AddWithValue("@Cargo", clsPersonal.cargo);
            cmd.Parameters.Add("@Foto", System.Data.SqlDbType.Image).Value = clsPersonal.foto;
            cnx.Open();

            cmd.ExecuteNonQuery();

            cnx.Close();
            retorno = 1;
            return retorno;

        }


      

        //public static int ActualizarDatosdPersonal(Controlador.Personal clsPersonal)
        //{
        //    int retorno = 0;
        //    SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
        //    cnx.Open();
        //    SqlCommand comando = new SqlCommand(string.Format("Update personal set Nombres='{0}', Apellidos='{1}', FechaNac='{2}', Foto='{3}', Cargo='{4}' where idPersonal={5}",
        //       clsPersonal.nombres, clsPersonal.apellidos, clsPersonal.fechanac, clsPersonal.foto, clsPersonal.cargo, clsPersonal.idpersonal), cnx);

        //    retorno = comando.ExecuteNonQuery();
        //    cnx.Close();

        //    return retorno;

        //}

        public bool VerificarSiExistePersonal(string dni)
        {


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM personal WHERE idPersonal='{0}'", dni), cnx);

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

        



    }
}
