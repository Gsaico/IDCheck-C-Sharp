using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCheck.Controlador
{
    class EmpresaColaboradora
    {

        public String nombreEmpresa { get; set; }
        public String gerente { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public String idEmpresaColaboradora { get; set; }

        public EmpresaColaboradora()
        {

        }

        public EmpresaColaboradora(String NombreEmpresa, String Gerente, String Telefono, String Email, String idEmpresaColaboradora)
        {
            this.nombreEmpresa = NombreEmpresa;
            this.gerente = Gerente;
            this.telefono = Telefono;
            this.email = Email;
            this.idEmpresaColaboradora = idEmpresaColaboradora;
            
        }

    }
}
