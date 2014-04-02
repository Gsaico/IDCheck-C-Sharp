using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCheck.Controlador
{
    class LogicaAcceso
    {



        public int autorizacion { get; set; }
        public String idacceso { get; set; }
        public byte[] foto { get; set; }
        public String apellidos { get; set; }
        public String nombres { get; set; }
        public String dni { get; set; }
        public String nombreempresa { get; set; }
        public String nombretipopersonal { get; set; }
        public String idTipoPersonal { get; set; }
        public String idEmpresaColaboradora { get; set; }





        public LogicaAcceso()
        {

        }


        public LogicaAcceso(int autorizacion, String idacceso, byte[] foto, String apellidos, String nombres, String dni,
            String nombreempresa, String nombretipopersonal, String idTipoPersonal, String idEmpresaColaboradora)
        {
            this.autorizacion = autorizacion;
            this.idacceso = idacceso;
            this.foto = foto;
            this.apellidos = apellidos;
            this.nombres = nombres;
            this.dni = dni;
            this.nombreempresa = nombreempresa;
            this.nombretipopersonal = nombretipopersonal;
            this.idTipoPersonal = idTipoPersonal;
            this.idEmpresaColaboradora = idEmpresaColaboradora;

        }
    }
}
