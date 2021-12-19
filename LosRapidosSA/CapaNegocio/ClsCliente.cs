using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClsCliente : ClsPersona
    {

        private string imagen;
        private string codigoCliente;

        public ClsCliente(){}
        public ClsCliente(String ced, String nom, String apel, Int16 eda, String dom, String sex, string imag, string codC) : base(ced, nom, apel, eda, dom, sex)
        {
            this.imagen = imag;
            this.codigoCliente = codC;
        
        }
        //metodos get /set
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        //Referencia al Manejador de la capa de acceso a datos
       



    }
}
