using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        // declaracion de atributos 
        private string asignatura;
        private string carrera;
        private string especialidad;
        private string lugarPractica;
        private string tiempoPractica;
        // propiedades para los atributos
        //propiedades de lectura GET - GETTER
        // propiedades de escritura SET-SETTER

        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }

        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        public string LugarPractica
        {
            get { return lugarPractica; }
            set { lugarPractica = value; }
        }
        public string TiempoPractica
        {
            get { return tiempoPractica; }
            set { tiempoPractica = value; }
        }
        // declaracion de metodos u operaciones
        public  string Aprender()
        {
            return "Este metodo recien sera implementado w_w";
        }
        public string GanarExperiencia()
        {
            return "Este metodo recien sera implementado w_w";
        }
        public string Trabajar()
        {
            return "Este metodo recien sera implemtado W_W";
        }
        public string Asistir()
        {
            return "Este metodo recien sera implementado W_W";
        }
        public string Practicar()
        {
            return "Este metodo recien sera implementado W_W";
        }
    }
}
