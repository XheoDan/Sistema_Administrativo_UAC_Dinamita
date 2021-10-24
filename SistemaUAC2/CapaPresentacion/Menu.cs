using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // llamar al formulario del alumno
            Form1 form1= new Form1();
            form1.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llamar al formulario del Docente
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llamar al formulario de laboratorio
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llamar al formulario Asignatura
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void jefeDePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llamar a formulario Jefe de Practica
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llamar a formulario Notas
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // llamar a formulario Rector
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void pPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llamar a formulario PP
            Form8 form8 = new Form8();
            form8.Show();
        }

        
    }
}
