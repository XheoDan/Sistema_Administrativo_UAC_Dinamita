using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// llamar a la capa negocio
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        //declarar un objeto a una clase 
        PPP pPP = new PPP();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //leer datos 
            string asignatura = txtAsignatura.Text.Trim();
            string carrera = txtCarrera.Text.Trim();
            string especialidad = txtEspecialidad.Text.Trim();
            string lugarPractica = txtLugarPractica.Text.Trim();
            string tiempoPractica = txtTiempoPractica.Text.Trim();

            //escribir los datos del Rector en le objeto
            pPP.Asignatura = asignatura;
            pPP.Carrera = carrera;
            pPP.Especialidad = especialidad;
            pPP.LugarPractica = lugarPractica;
            pPP.TiempoPractica = tiempoPractica;

            // confirmar que se escrbio en el objeto

            MessageBox.Show("Se a escrito correctamente el objeto");

            // limpiar las cajas de texto 
            txtAsignatura.Clear();
            txtCarrera.Clear();
            txtEspecialidad.Clear();
            txtLugarPractica.Clear();
            txtTiempoPractica.Clear();

            // el cursos de texto aparecera en el cuadrito 
            txtAsignatura.Focus();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //leer las propiedades del objeto
            string asignatura = pPP.Asignatura;
            string carrera = pPP.Carrera;
            string especialidad = pPP.Especialidad;
            string lugarPractica = pPP.LugarPractica;
            string tiempoPractica = pPP.TiempoPractica;
            //mandar mensaje
            MessageBox.Show("Datos PPP: " + "\n" + "\n" + "Asignatura:  " + asignatura + " \n" + "Carrera:  " + carrera +
                "\n" + " Especialidad :  " + especialidad + "\n" + " Lugar de Practica:  " + lugarPractica + "\n" +
                " Tiempo de Practica:  " + tiempoPractica);

        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //llamra  metodo 1
            MessageBox.Show(pPP.Aprender());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            //llamar a metodo 2
            MessageBox.Show(pPP.GanarExperiencia());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            //llamar a metodo 3
            MessageBox.Show(pPP.Trabajar());

        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            //llamar a metodo 4
            MessageBox.Show(pPP.Asistir());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            //llamar a metodo 5
            MessageBox.Show(pPP.Practicar());
        }
    }
}
