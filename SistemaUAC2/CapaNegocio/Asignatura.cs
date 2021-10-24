using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //declaracion de atributos
        public string curso;
        public string codigo;
        public string grupo;
        public string docente;
        public string ambiente;

        // propiedades para los atributos
        // propiedades de lectura get - getter
        // propiedades de escritura set - setter 
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public string Ambiente
        {
            get { return ambiente; }
            set { ambiente = value; }
        }
        // declaracion de metodos u operaciones 
        public string Enseniar()
        {
            return "Este metodo recien sera definido :c ";
        }
        public string Calificar()
        {
            return "Este metodo recien sera implementado  :c ";
        }
        public string Instruir()
        {
            return " Este metodo recien sera implentado :c ";
        }
        public string Aprender()
        {
            return " Este metodo recien sera implementado :C ";
        }
        public string   Asistir()
        {
            return "Este metdo recien sera implementado :c ";
        }
    }
}
