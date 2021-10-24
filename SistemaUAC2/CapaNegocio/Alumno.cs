using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        // declaracion de atributos 
        private string apellidos;
        private string nombres;
        private string celular;
        private string codigo;
        private string correo;
        private string semestreInicio;
        private string escuelaProfesional;

        //propiedades para los atributos 
        //propiedades de lectura GET - GETTER
        //propiedades de escritura SET - SETTER 
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string SemestreInicio
        {
            get { return semestreInicio; }
            set { semestreInicio = value; }
        }
        public string EscuelaProfesional
        {
            get { return escuelaProfesional; }
            set { escuelaProfesional = value; }

        }

        //declaracion de metedodos u operaciones
        public string Estudiar()
        {
            return "Este metodo recien sera implementado ";
        }
        public string Aprobar()
        {
            return "Este metodo recien sera implementado";
        }
        public string Ayudar()
        {
            return " Este metodo recien sera implementado";
        }
        public string Programar()
        {
            return "Este metodo recien sera implementado";
        }
        public string Desaprobar()
        {
            return "Este metodo recien sera implementado";
        }
    }
}
