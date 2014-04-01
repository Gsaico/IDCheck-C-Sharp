using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCheck.Controlador
{
    class Area
    {



        public int idarea { get; set; }
        public String nombrearea { get; set; }






        public Area()
        {

        }


        public Area(int Idarea, String Nombrearea)
        {
            this.idarea = Idarea;
            this.nombrearea = Nombrearea;
         
        }
    }
}
