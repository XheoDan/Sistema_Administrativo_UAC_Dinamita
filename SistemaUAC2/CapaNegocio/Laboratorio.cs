using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        // delcaracion de atributos 
        private string curso;
        private string jefeLaboratorio;
        private string horario;
        private string grupos;
        private string ubicacion;
        
        // propiedades para los atributos 
        // propiedades de lectura  GET - GETTER
        // porpiedades de escritura SET - SETTER 
        public string  Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public string JefeLaboratorio
        {
            get { return jefeLaboratorio; }
            set { jefeLaboratorio = value; }
        }
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public  string Grupos
        {
            get { return grupos; }
            set { grupos = value; }
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        //declaracion de metodos u operaciones 
        public string Practica()
        {
            return "Este metodo recien sera implementado :)";
        }
        public string Aprender()
        {
            return " Este metodo  recien sera implementado :)";
        }
        public string Experimentar()
        {
            return "Este metodo recien sera implementado :)";
        }
        public string Asistir()
        {
            return " Este metodo recien sera implementado :)";
        }
        public string Programar()
        {
            return "Este metodo recien sera implentado :)";
        }
    }
}
