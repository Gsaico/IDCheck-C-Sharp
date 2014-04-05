using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCheck.Controlador
{
    class Acceso
    {
    public String idpersonal { get; set; }
    public DateTime fecha { get; set; }
    public DateTime fechadesde { get; set; }
    public DateTime fechahasta { get; set; }
    public String nota { get; set; }
    public String essalud { get; set; }
    public String sctrsalud { get; set; }
    public String sctrpensiones { get; set; }
    public String pdtplame { get; set; }
    public String afp { get; set; }
    public String onp { get; set; }
    //dato obligatorio
    public String idarea { get; set; }
    
    public String idempresacolaboradora { get; set; }
    
//dato obligatorio
    public String idtipopersonal{ get; set; }





        


        public Acceso()
        {

        }


        public Acceso(String idpersonal, DateTime fecha, DateTime fechadesde, DateTime fechahasta, String nota,
         String essalud, String sctrsalud, String sctrpensiones, String pdtplame, String afp, String onp,
         String idarea, String idempresacolaboradora, String idtipopersonal)
        {
           this.idpersonal =idpersonal;
    this.fecha =fecha;

    this.fechadesde = fechadesde;
    this.fechahasta =fechahasta;
    this.nota =nota;
    this.essalud =essalud;
    this.sctrsalud =sctrsalud;
    this.sctrpensiones =sctrpensiones;
    this.pdtplame =pdtplame;
    this.afp =afp;
    this.onp =onp;
    //dato obligatorio
    this.idarea =idarea;
    
    this.idempresacolaboradora =idempresacolaboradora;
    
//dato obligatorio
    this.idtipopersonal=idtipopersonal;

        }





    }
}
