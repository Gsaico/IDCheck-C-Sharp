using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCheck.Controlador
{
    class Personal
    {

        public String idpersonal { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public DateTime fechanac { get; set; }
        public String cargo { get; set; }
        public byte[] foto { get; set; }








        public Personal()
        {

        }


        public Personal(String idpersonal, String nombres, String apellidos, DateTime fechanac, String cargo, byte[] foto)
        {
            this.idpersonal = idpersonal;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechanac = fechanac;
            this.cargo = cargo;
            this.foto = foto;
        }

    }
}
