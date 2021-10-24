
namespace CapaPresentacion
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label2 = new System.Windows.Forms.Label();
            this.txtJefeLaboratorio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrupos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnMetodo1 = new System.Windows.Forms.Button();
            this.btnMetodo2 = new System.Windows.Forms.Button();
            this.btnMetodo3 = new System.Windows.Forms.Button();
            this.btnMetodo4 = new System.Windows.Forms.Button();
            this.btnMetodo5 = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jefe de Laboratorio";
            // 
            // txtJefeLaboratorio
            // 
            this.txtJefeLaboratorio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtJefeLaboratorio.Location = new System.Drawing.Point(147, 86);
            this.txtJefeLaboratorio.Name = "txtJefeLaboratorio";
            this.txtJefeLaboratorio.Size = new System.Drawing.Size(100, 20);
            this.txtJefeLaboratorio.TabIndex = 3;
            this.txtJefeLaboratorio.TextChanged += new System.EventHandler(this.txtJefeLaboratorio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horario";
            // 
            // txtHorario
            // 
            this.txtHorario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtHorario.Location = new System.Drawing.Point(146, 133);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(100, 20);
            this.txtHorario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grupos";
            // 
            // txtGrupos
            // 
            this.txtGrupos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtGrupos.Location = new System.Drawing.Point(146, 171);
            this.txtGrupos.Name = "txtGrupos";
            this.txtGrupos.Size = new System.Drawing.Size(100, 20);
            this.txtGrupos.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ubicacion";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUbicacion.Location = new System.Drawing.Point(147, 207);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(100, 20);
            this.txtUbicacion.TabIndex = 9;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(100, 275);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 10;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(216, 275);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 11;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnMetodo1
            // 
            this.btnMetodo1.Location = new System.Drawing.Point(301, 42);
            this.btnMetodo1.Name = "btnMetodo1";
            this.btnMetodo1.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo1.TabIndex = 12;
            this.btnMetodo1.Text = "Metodo 1 ( )";
            this.btnMetodo1.UseVisualStyleBackColor = true;
            this.btnMetodo1.Click += new System.EventHandler(this.btnMetodo1_Click);
            // 
            // btnMetodo2
            // 
            this.btnMetodo2.Location = new System.Drawing.Point(301, 88);
            this.btnMetodo2.Name = "btnMetodo2";
            this.btnMetodo2.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo2.TabIndex = 13;
            this.btnMetodo2.Text = "Metodo 2 ( )";
            this.btnMetodo2.UseVisualStyleBackColor = true;
            this.btnMetodo2.Click += new System.EventHandler(this.btnMetodo2_Click);
            // 
            // btnMetodo3
            // 
            this.btnMetodo3.Location = new System.Drawing.Point(301, 133);
            this.btnMetodo3.Name = "btnMetodo3";
            this.btnMetodo3.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo3.TabIndex = 14;
            this.btnMetodo3.Text = "Metodo 3 ( )";
            this.btnMetodo3.UseVisualStyleBackColor = true;
            this.btnMetodo3.Click += new System.EventHandler(this.btnMetodo3_Click);
            // 
            // btnMetodo4
            // 
            this.btnMetodo4.Location = new System.Drawing.Point(301, 168);
            this.btnMetodo4.Name = "btnMetodo4";
            this.btnMetodo4.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo4.TabIndex = 15;
            this.btnMetodo4.Text = "Metodo 4 ( )";
            this.btnMetodo4.UseVisualStyleBackColor = true;
            this.btnMetodo4.Click += new System.EventHandler(this.btnMetodo4_Click);
            // 
            // btnMetodo5
            // 
            this.btnMetodo5.Location = new System.Drawing.Point(301, 209);
            this.btnMetodo5.Name = "btnMetodo5";
            this.btnMetodo5.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo5.TabIndex = 16;
            this.btnMetodo5.Text = "Metodo 5 ( )";
            this.btnMetodo5.UseVisualStyleBackColor = true;
            this.btnMetodo5.Click += new System.EventHandler(this.btnMetodo5_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCurso.Location = new System.Drawing.Point(147, 47);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 0;
            this.txtCurso.TextChanged += new System.EventHandler(this.txtCurso_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Curso";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(720, 326);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 319);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.btnMetodo5);
            this.Controls.Add(this.btnMetodo4);
            this.Controls.Add(this.btnMetodo3);
            this.Controls.Add(this.btnMetodo2);
            this.Controls.Add(this.btnMetodo1);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrupos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJefeLaboratorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form3";
            this.Text = "Sistema Administrativo  UAC  Laboratorio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnMetodo1;
        private System.Windows.Forms.Button btnMetodo2;
        private System.Windows.Forms.Button btnMetodo3;
        private System.Windows.Forms.Button btnMetodo4;
        private System.Windows.Forms.Button btnMetodo5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtJefeLaboratorio;        
        private System.Windows.Forms.TextBox txtHorario;    
        private System.Windows.Forms.TextBox txtGrupos;      
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}