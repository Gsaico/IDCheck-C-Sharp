using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IDCheck.Modelo
{
    class LogicaAcceso_BD
    {

        public Controlador.LogicaAcceso VerificarAutorizacion(Controlador.LogicaAcceso clsLogicaAcceso)
        {

            Controlador.LogicaAcceso clsLogicaAccesox = new Controlador.LogicaAcceso();
            MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format(
           "SELECT IF (date(now()) BETWEEN t1.FechaDesde AND t1.FechaHasta, 1,0) AS Autorizacion,  t1.idTipoPersonal, t1.idEmpresaColaboradora,  t2.Apellidos, t2.Nombres, t1.idpersonal AS DNI, " +
           "t3.NombreEmpresa, t4.NombreTipoPersonal, t2.Foto " +
           "FROM  acceso as t1 " +
           "INNER JOIN  personal AS t2   ON t1.idPersonal=t2.idPersonal " +
           "INNER JOIN  empresacolaboradora AS t3   ON t1.idEmpresaColaboradora=t3.idEmpresaColaboradora " +
           "INNER JOIN  tipopersonal AS t4  ON  t1.idTipoPersonal=t4.idTipoPersonal " +
           "WHERE  T1.idpersonal = '{0}'",  clsLogicaAcceso.idacceso), cnx);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clsLogicaAccesox.autorizacion = Convert.ToInt32(reader["Autorizacion"]);
                clsLogicaAccesox.apellidos = Convert.ToString(reader["Apellidos"]);
                clsLogicaAccesox.nombres = Convert.ToString(reader["Nombres"]);
                clsLogicaAccesox.dni = Convert.ToString(reader["DNI"]);
                clsLogicaAccesox.nombreempresa = Convert.ToString(reader["NombreEmpresa"]);
                clsLogicaAccesox.nombretipopersonal = Convert.ToString(reader["NombreTipoPersonal"]);
                clsLogicaAccesox.idTipoPersonal = Convert.ToString(reader["idTipoPersonal"]);
                clsLogicaAccesox.idEmpresaColaboradora = Convert.ToString(reader["idEmpresaColaboradora"]);
                clsLogicaAccesox.foto = (byte[])reader["Foto"];

               

            }
            cnx.Close();
            return clsLogicaAccesox;
        }

    }
}
