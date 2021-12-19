using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClsAmbulancia
    {
        protected String modelo;
        protected String tipoAmbulancia;  //Asistenciales, no asistenciales.
        protected String placa;
        protected String matricula;
        protected String fechaActivacion;
        protected String estado;
        protected String observacion;

        private List<Object> lst_obj;

        public ClsAmbulancia() { }
        public ClsAmbulancia(String modelo, String tipoAmbulancia,String placa, String matricula, String fechaActivacion,String estado,String observacion)
        {
            this.modelo = modelo;
            this.tipoAmbulancia = tipoAmbulancia;
            this.placa = placa;
            this.matricula = matricula;
            this.fechaActivacion = fechaActivacion;
            this.estado = estado;
            this.observacion = observacion;
         
        }

        //Getter and Setter fields
        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public String TipoAmbulancia
        {
            get { return tipoAmbulancia; }
            set { tipoAmbulancia = value; }
        }

        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public String Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public String FechaActivacion
        {
            get { return fechaActivacion; }
            set { fechaActivacion = value; }
        }

        public String Estado
        {

            get { return estado; }
            set { estado = value; }
        }

        public String Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
       

        //Métodos que pueden ser modificados por las clases hijos
        public virtual String registrar() { return ""; }
        public virtual List<Object> listar() { return lst_obj; }

        public virtual List<Object> buscar(String placa) { return lst_obj; }
        public virtual void eliminar(String placa) { }
        public virtual int actualizar_x_placa(string modelo, string tipoAmbulancia, string placa, string matricula, string fechaActivacion, string estado, string observacion)
        { return 0; }
    }

}

