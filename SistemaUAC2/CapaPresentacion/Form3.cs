using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// llamar a la capa  CapaNegocio

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // declarar un objeto de una clase
        Laboratorio laboratorio = new Laboratorio();
       
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // leer datos 
            string curso = txtCurso.Text.Trim();
            string jefeLaboratorio = txtJefeLaboratorio.Text.Trim();
            string horario = txtHorario.Text.Trim();
            string grupos = txtGrupos.Text.Trim();
            string ubicacion = txtUbicacion.Text.Trim();

            //escribir los datos del laboratorio en el objeto
            laboratorio.Curso = curso;
            laboratorio.JefeLaboratorio = jefeLaboratorio;
            laboratorio.Horario = horario;
            laboratorio.Grupos = grupos;
            laboratorio.Ubicacion = ubicacion;

            // confirmar que se a escrito en el objeto
            MessageBox.Show("Se a escrito correctamente el objeto");

            //limpiar las cajas de texto
            txtCurso.Clear();
            txtJefeLaboratorio.Clear();
            txtHorario.Clear();
            txtGrupos.Clear();
            txtUbicacion.Clear();

            // el cursor de texto aparecera en un cuadrito
            txtCurso.Focus();

        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propiedades del objeto 
            string curso = laboratorio.Curso;
            string jefeLaboratorio = laboratorio.JefeLaboratorio;
            string horario = laboratorio.Horario;
            string grupos = laboratorio.Grupos;
            string ubicacion = laboratorio.Ubicacion;

            // mandar mensaje

            MessageBox.Show("Datos de Laboratorio: " + "\n" + "\n" + "Curso:  " + curso + "\n" + "Jefe de Laboratorio:  " +
                jefeLaboratorio + "\n" + "Horario:  " + horario + "\n" + "Grupos:  " + grupos + "\n" + "Ubicacion:  " +
                ubicacion);


        }
        private void txtCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJefeLaboratorio_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //llamar a metodo 1
            MessageBox.Show(laboratorio.Practica());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            //llamar a metodo 2
            MessageBox.Show(laboratorio.Aprender());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            //llamar a metodo 3
            MessageBox.Show(laboratorio.Experimentar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            // llamar a metodo 4
            MessageBox.Show(laboratorio.Asistir());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            //llamar a metodo 5
            MessageBox.Show(laboratorio.Programar());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
