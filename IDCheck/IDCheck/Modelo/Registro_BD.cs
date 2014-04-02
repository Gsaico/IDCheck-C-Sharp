using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace IDCheck.Modelo
{
    class Registro_BD
    {

        public static int GrabarAcceso(Controlador.Registro clsRegistro)
        {

            int retorno = 0;
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            Controlador.Servidor clsSservidor = new Controlador.Servidor();
            Modelo.Servidor_BD clsServidorBD = new Modelo.Servidor_BD();
            clsSservidor=clsServidorBD.FechayHoradelServidor();
  
             var dt = DateTime.Parse(clsSservidor.datetimeservidor);
             string output = dt.ToString(@"yyyy/MM/dd hh:mm:ss", CultureInfo.InvariantCulture);
            



           // '01/04/2014 11:20:42 p.m.' 

            //    2014-03-27 15:15:43

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO registro(Fechayhora,idTipoPersonal,idEmpresaColaboradora,idAcceso,idEstado) VALUES('{0}','{1}','{2}', '{3}','{4}')",
            output, clsRegistro.idTipoPersonal, clsRegistro.idEmpresaColaboradora, clsRegistro.idAcceso, clsRegistro.idEstado), cnx);

            retorno = comando.ExecuteNonQuery();

            cnx.Close();
            return retorno;
        }


        public Controlador.Registro BuscarUltimoRegistrodeESxIDACCESO(Controlador.Registro clsRegistro)
        {

            Controlador.Registro clsRegistrox = new Controlador.Registro();
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();




            MySqlCommand comando = new MySqlCommand(String.Format(
           "SELECT  idRegistro,    Fechayhora, idTipoPersonal,    idEmpresaColaboradora,  idAcceso,    idEstado FROM registro WHERE  idAcceso='{0}' order by Fechayhora desc  limit 1", 
           clsRegistro.idAcceso), cnx);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsRegistrox.idRegistro = Convert.ToString(reader["idRegistro"]);
                clsRegistrox.Fechayhora = Convert.ToString(reader["Fechayhora"]);
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
