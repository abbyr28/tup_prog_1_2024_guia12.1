namespace Ejercicio1
{
    partial class FormCargar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.tbxHora = new System.Windows.Forms.TextBox();
            this.tbxMinuto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Competidor";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(219, 81);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(52, 13);
            this.lbNumero.TabIndex = 1;
            this.lbNumero.Text = "lbNumero";
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Location = new System.Drawing.Point(88, 215);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(42, 13);
            this.lbTiempo.TabIndex = 2;
            this.lbTiempo.Text = "Tiempo";
            // 
            // tbxHora
            // 
            this.tbxHora.Location = new System.Drawing.Point(252, 217);
            this.tbxHora.Name = "tbxHora";
            this.tbxHora.Size = new System.Drawing.Size(68, 20);
            this.tbxHora.TabIndex = 3;
            // 
            // tbxMinuto
            // 
            this.tbxMinuto.Location = new System.Drawing.Point(368, 217);
            this.tbxMinuto.Name = "tbxMinuto";
            this.tbxMinuto.Size = new System.Drawing.Size(85, 20);
            this.tbxMinuto.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(282, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxMinuto);
            this.Controls.Add(this.tbxHora);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.label1);
            this.Name = "FormCargar";
            this.Text = "Carga de tiempo del competidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lbNumero;
        public System.Windows.Forms.TextBox tbxHora;
        public System.Windows.Forms.TextBox tbxMinuto;
    }
}