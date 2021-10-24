using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// llamamos a la capa de negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //declarar un objeto de una clase

        Docente docente = new Docente();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
        // delcarar un objeto  a partir de la clase 
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //leer datos
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string materioaEnseniar = txtMateriaEnseniar.Text.Trim();
            // Esccribir los datos del docente en el objeto

            docente.Apellidos = apellidos;
            docente.Nombres = nombres;
            docente.Celular = celular;
            docente.Codigo = codigo;
            docente.Correo = correo;
            docente.MateriaEnseniar = materioaEnseniar;

            // confirmar que se a escrito en el objeto 
            MessageBox.Show("Se a escrito correctamente el objeto");
            // limpiarlas cajas de texto 
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtCodigo.Clear();
            txtCorreo.Clear();
            txtMateriaEnseniar.Clear();

            // el cursor de texto aparecera en un cuadrito
            txtApellidos.Focus();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // leer las propiedades del objeto
            string apellidos = docente.Apellidos;
            string nombres = docente.Nombres;
            string celular = docente.Celular;
            string codigo = docente.Codigo;
            string correo = docente.Correo;
            string materiaEnseniar = docente.MateriaEnseniar;
            // te respondera con el siguiente mensaje
            MessageBox.Show("Datos del Docente:" + "\n" + "\n" + "Apellidos:  " + apellidos + "\n" +
                "Nombres:  " + nombres + "\n" + "Celular:  " + celular + "\n" + "Codigo:  " +
                codigo + "\n" + "Correo:  " + correo + "\n" + "Materia a enseñar:  " + materiaEnseniar);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //llamar al metodo
            MessageBox.Show(docente.Enseniar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            //llamar al metodo
            MessageBox.Show(docente.Calificar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            // llamar al metodo
            MessageBox.Show(docente.Orientar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            //llamar al metodo
            MessageBox.Show(docente.Apoyar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            //llamar al metodo
            MessageBox.Show(docente.Exijir());
        }
    }
}
