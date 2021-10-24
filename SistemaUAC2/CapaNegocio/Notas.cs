using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        // declaracion de atributos
        public string parcial1;
        public string parcial2;
        public string parcial3;
        public string unidad;
        public string semestre;

        //propiedades para los atributos
        //propiedades de lectura GET-GETTER
        //propiedades de escritura SET -SETTER
        public string Parcial1
        {
            get { return parcial1; }
            set { parcial1 = value; }
        }
        public string Parcial2
        {
            get { return parcial2; }
            set { parcial2 = value; }
        }
        public string Parcial3
        {
            get { return parcial3; }
            set { parcial3 = value; }
        }
        public string Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        // declaracion de metodos u operaciones 
        public string Promediar()
        {
            return " Este metodo recien sera implementado +_+";
        }
        public string  Aprobar ()
        {
            return " Este  metodo recien sera implementado  +_+";
        }
        public string Desaprobar()
        {
            return " Este metodo recien sera implementado +_+";
        }
        public string Recuperar()
        {
            return "Este metodo recien sera implementado +_+";
        }
        public string Suspender()
        {
            return "Este metodo recien sera implementado +_+";
        }
    }
}
