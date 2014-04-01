using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IDCheck.Modelo
{
    class Acceso_BD
    {

        public Controlador.Acceso BuscarAccesoXIDpersonal(Controlador.Acceso clsAcceso)
        {

            Controlador.Acceso clsAccesox = new Controlador.Acceso();
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format(
           "SELECT idPersonal,Fecha,FechaDesde,FechaHasta,Nota,Essalud,sctrSalud,sctrPensiones,pdtplame,afp,onp,idArea,idTipoPersonal,idEmpresaColaboradora FROM acceso WHERE idPersonal='{0}'", clsAcceso.idpersonal), cnx);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsAccesox.idpersonal = Convert.ToString(reader["idPersonal"]);
                clsAccesox.fecha = Convert.ToString(reader["Fecha"]);
                clsAccesox.fechadesde = Convert.ToString(reader["FechaDesde"]);
                clsAccesox.fechahasta = Convert.ToString(reader["FechaHasta"]);
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


        public static int AgregarDatosdAcceso(Controlador.Acceso clsAcceso)
        {

            int retorno = 0;
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO acceso(idPersonal,Fecha,FechaDesde,FechaHasta,Nota,Essalud,sctrSalud,sctrPensiones,pdtplame,afp,onp,idArea,idTipoPersonal,idEmpresaColaboradora)"+

                                                                 "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
            clsAcceso.idpersonal, clsAcceso.fecha, clsAcceso.fechadesde, clsAcceso.fechahasta, clsAcceso.nota, clsAcceso.essalud, clsAcceso.sctrsalud, clsAcceso.sctrpensiones, clsAcceso.pdtplame, clsAcceso.afp, clsAcceso.onp, clsAcceso.idarea, clsAcceso.idtipopersonal, clsAcceso.idempresacolaboradora), cnx);

            retorno = comando.ExecuteNonQuery();

            cnx.Close();
            return retorno;
        }

        public static int ActualizarDatosdAcceso(Controlador.Acceso clsAcceso)
        {
            int retorno = 0;
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE acceso SET  Fecha ='{0}' , FechaDesde ='{1}' , FechaHasta ='{2}' ,  Nota ='{3}' , Essalud ='{4}' , sctrSalud ='{5}' , sctrPensiones ='{6}' , pdtplame ='{7}' , afp ='{8}' , onp ='{9}' , idArea ='{10}' , idTipoPersonal ='{11}' , idEmpresaColaboradora ='{12}' " +
                "WHERE idPersonal ='{13}' ",
               clsAcceso.fecha, clsAcceso.fechadesde, clsAcceso.fechahasta, clsAcceso.nota, clsAcceso.essalud, clsAcceso.sctrsalud, clsAcceso.sctrpensiones, clsAcceso.pdtplame, clsAcceso.afp, clsAcceso.onp, clsAcceso.idarea, clsAcceso.idtipopersonal, clsAcceso.idempresacolaboradora, clsAcceso.idpersonal), cnx);

            retorno = comando.ExecuteNonQuery();
            cnx.Close();

            return retorno;

        }

        public bool VerificarSiExisteIDacceso(string idPersonal)
        {


            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM acceso WHERE idPersonal='{0}'", idPersonal), cnx);

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
