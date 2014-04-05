using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCheck.Controlador
{
    class Registro
    {
      

public String idRegistro { get; set; }
public DateTime  Fechayhora { get; set; }
public String idEstado { get; set; }
public String idTipoPersonal { get; set; }
public String idEmpresaColaboradora { get; set; }
public String idAcceso { get; set; }



        public Registro()
        {

        }


        public Registro(String idRegistro, DateTime Fechayhora, String idEstado, String idTipoPersonal, String idEmpresaColaboradora, String idAcceso)
        {
         this.idRegistro=idRegistro;
this.Fechayhora=Fechayhora;
this.idEstado=idEstado;
this.idTipoPersonal=idTipoPersonal;
this.idEmpresaColaboradora=idEmpresaColaboradora;
this.idAcceso = idAcceso;
        }

    }
}
