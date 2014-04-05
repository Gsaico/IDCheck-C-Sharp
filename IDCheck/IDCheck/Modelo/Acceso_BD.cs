using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDCheck.Modelo
{
    class Acceso_BD
    {

        public Controlador.Acceso BuscarAccesoXIDpersonal(Controlador.Acceso clsAcceso)
        {

            Controlador.Acceso clsAccesox = new Controlador.Acceso();
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(String.Format(
           "SELECT idPersonal,Fecha,FechaDesde,FechaHasta,Nota,Essalud,sctrSalud,sctrPensiones,pdtplame,afp,onp,idArea,idTipoPersonal,idEmpresaColaboradora FROM acceso WHERE idPersonal='{0}'", clsAcceso.idpersonal), cnx);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsAccesox.idpersonal = Convert.ToString(reader["idPersonal"]);
                clsAccesox.fecha = Convert.ToDateTime(reader["Fecha"]);
                clsAccesox.fechadesde = Convert.ToDateTime(reader["FechaDesde"]);
                clsAccesox.fechahasta = Convert.ToDateTime(reader["FechaHasta"]);
                clsAccesox.nota = Convert.ToString(reader["Nota"]);

                clsAccesox.essalud = Convert.ToString(reader["Essalud"]);
                clsAccesox.sctrsalud = Convert.ToString(reader["sctrSalud"]);
                clsAccesox.sctrpensiones = Convert.ToString(reader["sctrPensiones"]);
                clsAccesox.pdtplame = Convert.ToString(reader["pdtplame"]);
                clsAccesox.afp = Convert.ToString(reader["afp"]);
                clsAccesox.onp = Convert.ToString(reader["onp"]);


                clsAccesox.idarea = Convert.ToString(reader["idArea"]);
                clsAccesox.idempresacolaboradora = Convert.ToString(reader["idEmpresaColaboradora"]);
                clsAccesox.idtipopersonal = Convert.ToString(reader["idTipoPersonal"]);



            }
            cnx.Close();
            return clsAccesox;
        }


        

        public static int insertardatosdeacceso(Controlador.Acceso clsAcceso)
        {

            int retorno = 0;
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            string query = "INSERT INTO acceso(idPersonal,Fecha,FechaDesde,FechaHasta,Nota,Essalud,sctrSalud,sctrPensiones,pdtplame,afp,onp,idArea,idTipoPersonal,idEmpresaColaboradora) VALUES(@idPersonal,@Fecha,@FechaDesde,@FechaHasta,@Nota,@Essalud,@sctrSalud,@sctrPensiones,@pdtplame,@afp,@onp,@idArea,@idTipoPersonal,@idEmpresaColaboradora)";
            SqlCommand cmd = new SqlCommand(query, cnx);
         
            cmd.Parameters.AddWithValue("@idPersonal", clsAcceso.idpersonal);
            cmd.Parameters.AddWithValue("@Fecha", clsAcceso.fecha);
            cmd.Parameters.AddWithValue("@FechaDesde", clsAcceso.fechadesde);
            cmd.Parameters.AddWithValue("@FechaHasta", clsAcceso.fechahasta);
            cmd.Parameters.AddWithValue("@Nota", clsAcceso.nota);
             cmd.Parameters.AddWithValue("@Essalud", clsAcceso.essalud);
            cmd.Parameters.AddWithValue("@sctrSalud", clsAcceso.sctrsalud);
            cmd.Parameters.AddWithValue("@sctrPensiones", clsAcceso.sctrpensiones);
            cmd.Parameters.AddWithValue("@pdtplame", clsAcceso.pdtplame);
             cmd.Parameters.AddWithValue("@afp", clsAcceso.afp);

             cmd.Parameters.AddWithValue("@onp", clsAcceso.onp);

             cmd.Parameters.AddWithValue("@idArea", clsAcceso.idarea);

             cmd.Parameters.AddWithValue("@idTipoPersonal", clsAcceso.idtipopersonal);

             cmd.Parameters.AddWithValue("@idEmpresaColaboradora", clsAcceso.idempresacolaboradora);

             cnx.Open();

            retorno = cmd.ExecuteNonQuery();

            cnx.Close();
            retorno = 1;
            return retorno;
        
        }







      

        public static int Actualizardatosdeacceso(Controlador.Acceso clsAcceso)
        {

            int retorno = 0;
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            string query =
            "UPDATE acceso SET  Fecha =@Fecha , FechaDesde =@FechaDesde , FechaHasta =@FechaHasta ,  Nota =@Nota , Essalud =@Essalud , sctrSalud =@sctrSalud , sctrPensiones =@sctrPensiones , pdtplame =@pdtplame , afp =@afp , onp =@onp , idArea =@idArea , idTipoPersonal =@idTipoPersonal , idEmpresaColaboradora =@idEmpresaColaboradora " +
                "WHERE idPersonal =@idPersonal ";
            SqlCommand cmd = new SqlCommand(query, cnx);

            cmd.Parameters.AddWithValue("@Fecha", clsAcceso.fecha);
            cmd.Parameters.AddWithValue("@FechaDesde", clsAcceso.fechadesde);
            cmd.Parameters.AddWithValue("@FechaHasta", clsAcceso.fechahasta);
            cmd.Parameters.AddWithValue("@Nota", clsAcceso.nota);
            cmd.Parameters.AddWithValue("@Essalud", clsAcceso.essalud);
            cmd.Parameters.AddWithValue("@sctrSalud", clsAcceso.sctrsalud);
            cmd.Parameters.AddWithValue("@sctrPensiones", clsAcceso.sctrpensiones);
            cmd.Parameters.AddWithValue("@pdtplame", clsAcceso.pdtplame);
            cmd.Parameters.AddWithValue("@afp", clsAcceso.afp);

            cmd.Parameters.AddWithValue("@onp", clsAcceso.onp);

            cmd.Parameters.AddWithValue("@idArea", clsAcceso.idarea);

            cmd.Parameters.AddWithValue("@idTipoPersonal", clsAcceso.idtipopersonal);

            cmd.Parameters.AddWithValue("@idEmpresaColaboradora", clsAcceso.idempresacolaboradora);
            cmd.Parameters.AddWithValue("@idPersonal", clsAcceso.idpersonal);
            cnx.Open();

            retorno = cmd.ExecuteNonQuery();

            cnx.Close();
            retorno = 1;
            return retorno;

        }


        public bool VerificarSiExisteIDacceso(string idPersonal)
        {


            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM acceso WHERE idPersonal='{0}'", idPersonal), cnx);

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

