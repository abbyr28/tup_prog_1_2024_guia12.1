namespace Ejercicio1
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
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnVerResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Location = new System.Drawing.Point(254, 33);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(212, 77);
            this.btnAgregarC.TabIndex = 0;
            this.btnAgregarC.Text = "Agregar Competidor";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(254, 139);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(211, 80);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar tiempos de competidores";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnVerResultado
            // 
            this.btnVerResultado.Location = new System.Drawing.Point(252, 247);
            this.btnVerResultado.Name = "btnVerResultado";
            this.btnVerResultado.Size = new System.Drawing.Size(212, 78);
            this.btnVerResultado.TabIndex = 2;
            this.btnVerResultado.Text = "Ver Resultados";
            this.btnVerResultado.UseVisualStyleBackColor = true;
            this.btnVerResultado.Click += new System.EventHandler(this.btnVerResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerResultado);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnAgregarC);
            this.Name = "Form1";
            this.Text = "Ejercicio1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnVerResultado;
    }
}

