using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public  class Rector
    {
        //declaracion de atributos 
        public string nombres;
        public string apellidos;
        public string correo;
        public string dni;
        public string experienciaAcademica;
        //propiedades  para los atributos
        // propiedades de lectura  get- getter
        // propiedades de escritura set - setter
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
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string ExperienciaAcademica
        {
            get { return experienciaAcademica; }
            set { experienciaAcademica = value; }
        }
        // declaracion de metodos y operaciones
        public string Supervisar()
        {
            return "Este metodo  recien sera implementado n_n";
        }
        public string Proponer()
        {
            return "Este nmetodo recien sera implementado n_n";
        }
        public string Inspeccionar()
        {
            return " Este metodo recien sera implemtado n_n";
        }
        public string Evaluar()
        {
            return "Este metodo recien sera implemtado n_n";
        }
        public string Gestionar()
        {
            return "Este metodo recien sera implemtado n_n";
        }

    }
}
