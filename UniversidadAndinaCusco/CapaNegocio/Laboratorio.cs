using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        //atributos
        private string nombres;
        private string ubicacion;
        private int creditos;
        //propiedades
        public string Nombres
        {
            get { return nombres; }// Lectura de atributos
            set { nombres = value; }// Escritura de atributos
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public int Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }

       //Metodos u operaciones
       public string Experimetar()
        {
            return "No se ha implementado el metodo experimentar";
        }
        public string Ensamblar()
        {
            return "No se ha implementado el metodo ensamblar";
        }
        public string Cortar()
        {
            return "No se ha implenmentado el metodo Cortar";
        }
    }
}
