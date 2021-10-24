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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // declarar un objeto de una clase
        Alumno alumno = new Alumno();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // leer datos 
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string semestreInicio = txtSemestreInicio.Text.Trim();
            string escuelaProfesional = txtEscuelaProfesional.Text.Trim();

            //escribir los datos del alumno en el objeto
            
            alumno.Apellidos = apellidos;
            alumno.Nombres = nombres;
            alumno.Celular = celular;
            alumno.Codigo = codigo;
            alumno.Correo = correo;
            alumno.SemestreInicio = semestreInicio;
            alumno.EscuelaProfesional = escuelaProfesional;
            // confirmar  que se ha escrito   en el objeto
            MessageBox.Show(" Se ha escrito  correctament el objeto");
            // limpiar  las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtCodigo.Clear();
            txtCorreo.Clear();
            txtSemestreInicio.Clear();
            txtEscuelaProfesional.Clear();
            // el cursor de texto aparecera en un cuadrito
            txtApellidos.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // LEER LAS propiedades del objeto 
            string apellidos = alumno.Apellidos;
            string nombres = alumno.Nombres;
            string celular = alumno.Celular;
            string codigo = alumno.Codigo;
            string correo = alumno.Correo;
            string semestreInicio = alumno.SemestreInicio;
            string escuelaProfesional = alumno.EscuelaProfesional;

            //mandar mensaje

            MessageBox.Show("Datos del alumno " + "\n"+"\n" + "Apellidos:  " + apellidos + "\n" +
                "nombres:  " + nombres + "\n" + "Celular:  " + celular + "\n" + "codigo:  " +
                codigo + "\n" + "Correo:  " + correo + "\n" + "Semestre Inicio  :"  +
                semestreInicio + "\n" + "Escuela  Profesional:  " + escuelaProfesional);

        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            // llamar al metodo 1
            MessageBox.Show(alumno.Estudiar());

        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            // llamar a un metodo 2
            MessageBox.Show(alumno.Aprobar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            //lamando a metodo 3
            MessageBox.Show(alumno.Ayudar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            // llamando a metodo 4 
            MessageBox.Show(alumno.Programar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            // llamando a metodo 5
            MessageBox.Show(alumno.Desaprobar());
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
