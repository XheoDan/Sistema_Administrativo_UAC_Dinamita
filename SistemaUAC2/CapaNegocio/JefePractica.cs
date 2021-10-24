using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        // declaracion de atributos
        private string nombres;
        private string apellidos;
        private string seccionCargo;
        private string telefono;
        private string gmail;

        //propiedades para los atributos
        //propiedades de lectura GET - GETTER
        //propiedades de escritura SET - SETTER 

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string SeccionCargo
        {
            get { return seccionCargo; }
            set { seccionCargo = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Gmail
        {
            get { return gmail; }
            set { gmail = value; }
        }
        //declaracion de metodos y operaciones 
        public string Supervisar()
        {
            return "Este metodo recien sera definido =_=";
        }
        public string Instruir()
        {
            return "Este metodo recien sera  definido =_=";
        }
        public string Exigir()
        {
            return "Este metodo recien sera definido =_=";
        }
        public string Investigar()
        {
            return "Este metodo recien sera definido =_=";
        }
        public string  Apoyar()
        {
            return "Este metodo recien sera definido =_=";
        }
    }
}
