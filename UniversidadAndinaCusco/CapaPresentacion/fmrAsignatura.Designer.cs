
namespace CapaPresentacion
{
    partial class fmrAsignatura
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
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtNotaAprobar = new System.Windows.Forms.TextBox();
            this.btnEstudiar = new System.Windows.Forms.Button();
            this.btnParticipar = new System.Windows.Forms.Button();
            this.btnPreguntar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(267, 55);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 0;
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(267, 91);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(100, 20);
            this.txtCreditos.TabIndex = 1;
            // 
            // txtNotaAprobar
            // 
            this.txtNotaAprobar.Location = new System.Drawing.Point(267, 133);
            this.txtNotaAprobar.Name = "txtNotaAprobar";
            this.txtNotaAprobar.Size = new System.Drawing.Size(100, 20);
            this.txtNotaAprobar.TabIndex = 2;
            // 
            // btnEstudiar
            // 
            this.btnEstudiar.Location = new System.Drawing.Point(190, 250);
            this.btnEstudiar.Name = "btnEstudiar";
            this.btnEstudiar.Size = new System.Drawing.Size(75, 23);
            this.btnEstudiar.TabIndex = 3;
            this.btnEstudiar.Text = "Estudiar";
            this.btnEstudiar.UseVisualStyleBackColor = true;
            this.btnEstudiar.Click += new System.EventHandler(this.btnEstudiar_Click);
            // 
            // btnParticipar
            // 
            this.btnParticipar.Location = new System.Drawing.Point(329, 250);
            this.btnParticipar.Name = "btnParticipar";
            this.btnParticipar.Size = new System.Drawing.Size(75, 23);
            this.btnParticipar.TabIndex = 4;
            this.btnParticipar.Text = "Participar";
            this.btnParticipar.UseVisualStyleBackColor = true;
            this.btnParticipar.Click += new System.EventHandler(this.btnParticipar_Click);
            // 
            // btnPreguntar
            // 
            this.btnPreguntar.Location = new System.Drawing.Point(440, 250);
            this.btnPreguntar.Name = "btnPreguntar";
            this.btnPreguntar.Size = new System.Drawing.Size(75, 23);
            this.btnPreguntar.TabIndex = 5;
            this.btnPreguntar.Text = "Preguntar";
            this.btnPreguntar.UseVisualStyleBackColor = true;
            this.btnPreguntar.Click += new System.EventHandler(this.btnPreguntar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(440, 51);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 6;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(440, 90);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 7;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Creditos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "NotaAprobar";
            // 
            // fmrAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnPreguntar);
            this.Controls.Add(this.btnParticipar);
            this.Controls.Add(this.btnEstudiar);
            this.Controls.Add(this.txtNotaAprobar);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtNombres);
            this.Name = "fmrAsignatura";
            this.Text = "trabajar con la clase asignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtNotaAprobar;
        private System.Windows.Forms.Button btnEstudiar;
        private System.Windows.Forms.Button btnParticipar;
        private System.Windows.Forms.Button btnPreguntar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}