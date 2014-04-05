using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCheck.Controlador
{
    class Administrador
    {
         public String idpersonal { get; set; }
        public String pasword { get; set; }
      








        public Administrador()
        {

        }


        public Administrador(String idpersonal, String pasword)
        {
            this.idpersonal = idpersonal;
            this.pasword = pasword;
          
        }



    }
}
