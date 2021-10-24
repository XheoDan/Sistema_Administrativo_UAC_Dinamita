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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        //declarar un objeto a una clase 
        Rector rector = new Rector();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //leer datos 
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string dni = txtDni.Text.Trim();
            string experienciaAcademica = txtExperienciaAcademica.Text.Trim();

            //escribir los datos del Rector en le objeto
            rector.Nombres = nombres;
            rector.Apellidos = apellidos;
            rector.Correo = correo;
            rector.Dni = dni;
            rector.ExperienciaAcademica = experienciaAcademica;

            // confirmar que se escrbio en el objeto

            MessageBox.Show("Se a escrito correctamente el objeto");

            // limpiar las cajas de texto 
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtDni.Clear();
            txtExperienciaAcademica.Clear();

            // el cursos de texto aparecera en el cuadrito 
            txtNombres.Focus();


        }
       

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //leer las propiedades del objeto
            string nombres = rector.Nombres;
            string apellidos = rector.Apellidos;
            string correo = rector.Correo;
            string dni = rector.Dni;
            string experienciaAcademica = rector.ExperienciaAcademica;

            //mandar mensaje
            MessageBox.Show("Datos del Rector: " + "\n" + "\n" + "Nombres:  " + nombres + " \n" + "Apellidos:  " + apellidos +
                "\n" + "correo:  " + correo + "\n" + "Dni:  " + dni + "\n" + " Experienca Academica:  " + 
                experienciaAcademica);



        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //llamar a metodo 1
            MessageBox.Show(rector.Supervisar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            //llamar a metodo 2
            MessageBox.Show(rector.Proponer());

        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            //llamar a metodo 3
            MessageBox.Show(rector.Inspeccionar());

        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            //llamar a metodo 4
            MessageBox.Show(rector.Evaluar());
        }
        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            //llamar a metodo 5
            MessageBox.Show(rector.Gestionar());
        }
    }
}
