using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//llamar a la capa negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        // Declarar un onjeto de una clase
        Asignatura asignatura = new Asignatura();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //leer datos
            string curso = txtCurso.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string grupo = txtGrupo.Text.Trim();
            string docente = txtDocente.Text.Trim();
            string ambiente = txtAmbiente.Text.Trim();

            // escribir los datos de asignatura en el objeto
            asignatura.Curso = curso;
            asignatura.Codigo = codigo;
            asignatura.Grupo = grupo;
            asignatura.Docente = docente;
            asignatura.Ambiente = ambiente;

            // confirmar que se a escrito en el objeto
            MessageBox.Show("Se a escrito correctamente el objeto");

            //limpiar las cajas de texto
            txtCurso.Clear();
            txtCodigo.Clear();
            txtGrupo.Clear();
            txtDocente.Clear();
            txtAmbiente.Clear();

            // el cursor de texto aparecera en un cuadrito

            txtCurso.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // leer  las propiedades del objeto 
            string curso = asignatura.Curso;
            string codigo = asignatura.Codigo;
            string grupo = asignatura.Grupo;
            string docente = asignatura.Docente;
            string ambiente = asignatura.Ambiente;

            //mandar mensaje
            MessageBox.Show("Datos de la Asignatura" + "\n" + "\n" + "Curso:  " + curso + "\n" + "Codigo:  " + codigo + "\n"
                + "Grupo:  " + grupo + "\n" + "Docente:  " + docente + "\n" + "Ambiente:  " + ambiente);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //llmar a metodo 1
            MessageBox.Show(asignatura.Enseniar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            //llamar a metodo 2
            MessageBox.Show(asignatura.Calificar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            //llamar a metodo 3
            MessageBox.Show(asignatura.Instruir());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            //llamar a metodo 4
            MessageBox.Show(asignatura.Aprender());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            //llamar a metodo 5
            MessageBox.Show(asignatura.Asistir());
        }
    }
}
