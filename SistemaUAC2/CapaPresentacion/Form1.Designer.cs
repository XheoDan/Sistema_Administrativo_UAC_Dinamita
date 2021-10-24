
namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtSemestreInicio = new System.Windows.Forms.TextBox();
            this.txtEscuelaProfesional = new System.Windows.Forms.TextBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnMetodo1 = new System.Windows.Forms.Button();
            this.btnMetodo2 = new System.Windows.Forms.Button();
            this.btnMetodo3 = new System.Windows.Forms.Button();
            this.btnMetodo4 = new System.Windows.Forms.Button();
            this.btnMetodo5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(165, 42);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 0;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(165, 81);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(165, 120);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(165, 157);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(165, 193);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 4;
            // 
            // txtSemestreInicio
            // 
            this.txtSemestreInicio.Location = new System.Drawing.Point(165, 236);
            this.txtSemestreInicio.Name = "txtSemestreInicio";
            this.txtSemestreInicio.Size = new System.Drawing.Size(100, 20);
            this.txtSemestreInicio.TabIndex = 5;
            // 
            // txtEscuelaProfesional
            // 
            this.txtEscuelaProfesional.Location = new System.Drawing.Point(165, 278);
            this.txtEscuelaProfesional.Name = "txtEscuelaProfesional";
            this.txtEscuelaProfesional.Size = new System.Drawing.Size(100, 20);
            this.txtEscuelaProfesional.TabIndex = 6;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(103, 343);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 7;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(248, 343);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 8;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnMetodo1
            // 
            this.btnMetodo1.Location = new System.Drawing.Point(319, 42);
            this.btnMetodo1.Name = "btnMetodo1";
            this.btnMetodo1.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo1.TabIndex = 9;
            this.btnMetodo1.Text = "Metodo 1 ( )";
            this.btnMetodo1.UseVisualStyleBackColor = true;
            this.btnMetodo1.Click += new System.EventHandler(this.btnMetodo1_Click);
            // 
            // btnMetodo2
            // 
            this.btnMetodo2.Location = new System.Drawing.Point(319, 92);
            this.btnMetodo2.Name = "btnMetodo2";
            this.btnMetodo2.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo2.TabIndex = 10;
            this.btnMetodo2.Text = "Metodo 2 ( )";
            this.btnMetodo2.UseVisualStyleBackColor = true;
            this.btnMetodo2.Click += new System.EventHandler(this.btnMetodo2_Click);
            // 
            // btnMetodo3
            // 
            this.btnMetodo3.Location = new System.Drawing.Point(319, 150);
            this.btnMetodo3.Name = "btnMetodo3";
            this.btnMetodo3.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo3.TabIndex = 11;
            this.btnMetodo3.Text = "Metodo 3 ( )";
            this.btnMetodo3.UseVisualStyleBackColor = true;
            this.btnMetodo3.Click += new System.EventHandler(this.btnMetodo3_Click);
            // 
            // btnMetodo4
            // 
            this.btnMetodo4.Location = new System.Drawing.Point(319, 200);
            this.btnMetodo4.Name = "btnMetodo4";
            this.btnMetodo4.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo4.TabIndex = 12;
            this.btnMetodo4.Text = "Metodo 4 ( )";
            this.btnMetodo4.UseVisualStyleBackColor = true;
            this.btnMetodo4.Click += new System.EventHandler(this.btnMetodo4_Click);
            // 
            // btnMetodo5
            // 
            this.btnMetodo5.Location = new System.Drawing.Point(319, 260);
            this.btnMetodo5.Name = "btnMetodo5";
            this.btnMetodo5.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo5.TabIndex = 13;
            this.btnMetodo5.Text = "Metodo 5 ( )";
            this.btnMetodo5.UseVisualStyleBackColor = true;
            this.btnMetodo5.Click += new System.EventHandler(this.btnMetodo5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Semestre Inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Escuela Profesional";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-23, -21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(765, 433);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 394);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMetodo5);
            this.Controls.Add(this.btnMetodo4);
            this.Controls.Add(this.btnMetodo3);
            this.Controls.Add(this.btnMetodo2);
            this.Controls.Add(this.btnMetodo1);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.txtEscuelaProfesional);
            this.Controls.Add(this.txtSemestreInicio);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Sistema Administrativo UAC   Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtSemestreInicio;
        private System.Windows.Forms.TextBox txtEscuelaProfesional;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnMetodo1;
        private System.Windows.Forms.Button btnMetodo2;
        private System.Windows.Forms.Button btnMetodo3;
        private System.Windows.Forms.Button btnMetodo4;
        private System.Windows.Forms.Button btnMetodo5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

