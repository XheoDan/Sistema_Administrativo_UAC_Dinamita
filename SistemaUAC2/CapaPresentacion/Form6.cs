using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//llarma a capa Negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        // delcarar un objeto a una clase 

        Notas notas = new Notas();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //leer datos
            string parcial1 = txtParcial1.Text.Trim();
            string parcial2 = txtParcial2.Text.Trim();
            string parcial3 = txtParcial3.Text.Trim();
            string unidad = txtUnidad.Text.Trim();
            string semestre = txtSemestre.Text.Trim();

            //escribir los datos de las notas en el objeto
            notas.Parcial1 = parcial1;
            notas.Parcial2 = parcial2;
            notas.Parcial3 = parcial3;
            notas.Unidad = unidad;
            notas.Semestre = semestre;

            // confirmar que se escribio en el objeto
            MessageBox.Show("Se a escrito correctamente el objeto");

            // limpiar las cajas de texto

            txtParcial1.Clear();
            txtParcial2.Clear();
            txtParcial3.Clear();
            txtUnidad.Clear();
            txtSemestre.Clear();

            // el cursor de texto aparecera en un cuadrito
            txtParcial1.Focus();




        }

        private void txtParcial1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // leer las propiedades del objeto
            string parcial1 = notas.Parcial1;
            string parcial2 = notas.Parcial2;
            string parcial3 = notas.Parcial3;
            string unidad = notas.Unidad;
            string semestre = notas.Semestre;

            //mandar mensaje
            MessageBox.Show("Notas:" + "\n" + "\n" + "Parcial 1:  " + parcial1 + "\n" + "Parcial 2:  " + parcial2 + "\n"
                + "Parcial 3:  " + parcial3 + "\n" + "Unidad:  " + unidad + "\n" + "Semestre:  " + semestre);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //llamar a metodo 1
            MessageBox.Show(notas.Promediar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            //llamar a metodo 2
            MessageBox.Show(notas.Aprobar());

        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            //llamar a metodo 3
            MessageBox.Show(notas.Desaprobar());

        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            //llamar a metodo 4 
            MessageBox.Show(notas.Recuperar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            //llamar a metodo 5
            MessageBox.Show(notas.Suspender());
        }
    }
}
