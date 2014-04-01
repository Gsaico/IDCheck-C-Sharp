using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCheck.Controlador
{
    class TipoPersonal
    {
        public int tipoPersonal { get; set; }
        public String nombreTipoPersonal { get; set; }


        



        public TipoPersonal()
        {

        }


        public TipoPersonal(int TipoPersonal, String NombreTipoPersonal)
        {
            this.tipoPersonal = TipoPersonal;
            this.nombreTipoPersonal = NombreTipoPersonal;
         
        }
    }
}
