using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
using System.Data.SqlClient;

namespace IDCheck.Modelo
{
    class Registro_BD
    {

        public static int GrabarAcceso(Controlador.Registro clsRegistro)
        {

            int retorno = 0;
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();
            Controlador.Servidor clsSservidor = new Controlador.Servidor();
            Modelo.Servidor_BD clsServidorBD = new Modelo.Servidor_BD();
            clsSservidor = clsServidorBD.FechayHoradelServidor();

           // var dt = clsSservidor.datetimeservidor;
           // string output = dt.ToString(@"yyyy/MM/dd hh:mm:ss", CultureInfo.InvariantCulture);




            // '01/04/2014 11:20:42 p.m.' 

            //    2014-03-27 15:15:43

            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO registro(Fechayhora,idTipoPersonal,idEmpresaColaboradora,idAcceso,idEstado) VALUES('{0}','{1}','{2}', '{3}','{4}')",
            clsSservidor.datetimeservidor, clsRegistro.idTipoPersonal, clsRegistro.idEmpresaColaboradora, clsRegistro.idAcceso, clsRegistro.idEstado), cnx);

            retorno = comando.ExecuteNonQuery();

            cnx.Close();
            return retorno;
        }


        public static int insertarAcceso(Controlador.Registro clsRegistro)
        {
            Controlador.Servidor clsSservidor = new Controlador.Servidor();
            Modelo.Servidor_BD clsServidorBD = new Modelo.Servidor_BD();
            clsSservidor = clsServidorBD.FechayHoradelServidor();

            int retorno = 0;
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            string query = "INSERT INTO registro(Fechayhora,idTipoPersonal,idEmpresaColaboradora,idAcceso,idEstado) VALUES(@Fechayhora,@idTipoPersonal,@idEmpresaColaboradora,@idAcceso,@idEstado)";
            SqlCommand cmd = new SqlCommand(query, cnx);



            cmd.Parameters.AddWithValue("@Fechayhora", clsSservidor.datetimeservidor);
            cmd.Parameters.AddWithValue("@idTipoPersonal", clsRegistro.idTipoPersonal);
            cmd.Parameters.AddWithValue("@idEmpresaColaboradora", clsRegistro.idEmpresaColaboradora);
            cmd.Parameters.AddWithValue("@idAcceso", clsRegistro.idAcceso);
            cmd.Parameters.AddWithValue("@idEstado", clsRegistro.idEstado);
         

            cnx.Open();

            retorno = cmd.ExecuteNonQuery();

            cnx.Close();
            return retorno;

        }


        public Controlador.Registro BuscarUltimoRegistrodeESxIDACCESO(Controlador.Registro clsRegistro)
        {

            Controlador.Registro clsRegistrox = new Controlador.Registro();
            SqlConnection cnx = Conexion.Conexion.ObtenerConexion();
            cnx.Open();



            SqlCommand comando = new SqlCommand(String.Format(
           "SELECT  TOP (1) idRegistro,    Fechayhora, idTipoPersonal,    idEmpresaColaboradora,  idAcceso,    idEstado FROM registro WHERE  idAcceso='{0}' order by Fechayhora desc",
           clsRegistro.idAcceso), cnx);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsRegistrox.idRegistro = Convert.ToString(reader["idRegistro"]);
                clsRegistrox.Fechayhora = Convert.ToDateTime(reader["Fechayhora"]);
                clsRegistrox.idTipoPersonal = Convert.ToString(reader["idTipoPersonal"]);
                clsRegistrox.idEmpresaColaboradora = Convert.ToString(reader["idEmpresaColaboradora"]);
                clsRegistrox.idAcceso = Convert.ToString(reader["idAcceso"]);
                clsRegistrox.idEstado = Convert.ToString(reader["idEstado"]);




            }
            cnx.Close();
            return clsRegistrox;
        }



    }
}
