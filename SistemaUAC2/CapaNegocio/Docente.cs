using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class Docente
    {
        // declaracion de atributos 
        private string apellidos;
        private string nombres;
        private string celular;
        private string codigo;
        private string correo;
        private string materiaEnseniar;


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
        public string MateriaEnseniar
        {
            get { return materiaEnseniar; }
            set { materiaEnseniar = value; }
        }




        //declaracion de metedodos u operaciones
        public string Enseniar()
        {
            return "Este metodo recien sera implementado ";
        }
        public string Calificar()
        {
            return "Este metodo recien sera implementado";
        }
        public string Orientar()
        {
            return " Este metodo recien sera implementado";
        }
        public string Apoyar()
        {
            return "Este metodo recien sera implementado";
        }
        public string Exijir()
        {
            return "Este metodo recien sera implementado";
        }
    }
}