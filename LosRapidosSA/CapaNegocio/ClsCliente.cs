﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClsCliente : ClsPersona
    {

        private String imagen;
        private String codigoCliente;

        public ClsCliente(){}
        public ClsCliente(String ced, String nom, String apel, Int16 eda, String dom, String sex, String imag, String codC) : base(ced, nom, apel, eda, dom, sex)
        {
            this.imagen = imag;
            this.codigoCliente = codC;
        
        }
        //metodos get /set
        public String Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        public String CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }

        //Referencia al Manejador de la capa de acceso a datos

        ClsManejador M = new ClsManejador();

        public override String registrar()
        {
            string msj = "";


            //Lista genérica de parámetros
            List<ClsParametrosCliente> lst = new List<ClsParametrosCliente>();

            try
            {
                //Pasar los parámetros hacia la capa de acceso a datos
                lst.Add(new ClsParametrosCliente(Cedula, Nombre, Apellido, Edad, Domicilio,Sexo, Imagen, CodigoCliente));
                M.insertar_alumno(lst);


                msj = "Insertado correctamente";

            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

    }
}
