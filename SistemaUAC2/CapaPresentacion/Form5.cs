using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// llamar a capa negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //declarar un objeto a una clase 
        JefePractica jefePractica = new JefePractica();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //leer datos
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string seccionCargo = txtSeccionCargo.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string gmail = txtGmail.Text.Trim();

            // escribir los datos de Jefe a cargo en el objeto
            jefePractica.Nombres = nombres;
            jefePractica.Apellidos = apellidos;
            jefePractica.SeccionCargo = seccionCargo;
            jefePractica.Telefono = telefono;
            jefePractica.Gmail = gmail;

            // confirmar que se a escrito en el objeto
            MessageBox.Show("Se a escrito correctamente el objeto");

            //limpiar las cajas de texto
            txtNombres.Clear();
            txtApellidos.Clear();
            txtSeccionCargo.Clear();
            txtTelefono.Clear();
            txtGmail.Clear();

            // el cursor de texto aparecera en un cuadrito
            txtNombres.Focus();


        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // leer  las propiedades del objeto 
            string nombres = jefePractica.Nombres;
            string apellidos = jefePractica.Apellidos;
            string seccionCargo = jefePractica.SeccionCargo;
            string telefono = jefePractica.Telefono;
            string gmail = jefePractica.Gmail;

            // mandar mensaje

            MessageBox.Show("Datos de Jefe de Practica: " + "\n" + "\n" + "Nombre:  " + nombres + "\n" +
                "Apellidos:  " + apellidos + "\n" + "Seccion a Cargo:  " + seccionCargo + "\n" + "Telefono:  "
                + telefono + "\n" + "Gmail:  " + gmail);

        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //llamar a metodo 1
            MessageBox.Show(jefePractica.Supervisar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            //llamar a metodo 2
            MessageBox.Show(jefePractica.Instruir());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            //llamar a metodo 3
            MessageBox.Show(jefePractica.Exigir());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            //llamar a metodo 4
            MessageBox.Show(jefePractica.Investigar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            //llamar a metodo 5
            MessageBox.Show(jefePractica.Apoyar());
        }
    }
}