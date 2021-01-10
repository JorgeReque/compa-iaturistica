namespace compañia_turistica
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
            this.btnReservar = new System.Windows.Forms.Button();
            this.richTexResultado = new System.Windows.Forms.RichTextBox();
            this.rbCarro = new System.Windows.Forms.RadioButton();
            this.rbHelicoptero = new System.Windows.Forms.RadioButton();
            this.rbLancha = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(134, 228);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 0;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // richTexResultado
            // 
            this.richTexResultado.Location = new System.Drawing.Point(273, 94);
            this.richTexResultado.Name = "richTexResultado";
            this.richTexResultado.Size = new System.Drawing.Size(158, 96);
            this.richTexResultado.TabIndex = 1;
            this.richTexResultado.Text = "";
            // 
            // rbCarro
            // 
            this.rbCarro.AutoSize = true;
            this.rbCarro.Location = new System.Drawing.Point(29, 19);
            this.rbCarro.Name = "rbCarro";
            this.rbCarro.Size = new System.Drawing.Size(50, 17);
            this.rbCarro.TabIndex = 2;
            this.rbCarro.TabStop = true;
            this.rbCarro.Text = "Carro";
            this.rbCarro.UseVisualStyleBackColor = true;
            // 
            // rbHelicoptero
            // 
            this.rbHelicoptero.AutoSize = true;
            this.rbHelicoptero.Location = new System.Drawing.Point(24, 58);
            this.rbHelicoptero.Name = "rbHelicoptero";
            this.rbHelicoptero.Size = new System.Drawing.Size(79, 17);
            this.rbHelicoptero.TabIndex = 3;
            this.rbHelicoptero.TabStop = true;
            this.rbHelicoptero.Text = "Helicoptero";
            this.rbHelicoptero.UseVisualStyleBackColor = true;
            // 
            // rbLancha
            // 
            this.rbLancha.AutoSize = true;
            this.rbLancha.Location = new System.Drawing.Point(29, 95);
            this.rbLancha.Name = "rbLancha";
            this.rbLancha.Size = new System.Drawing.Size(61, 17);
            this.rbLancha.TabIndex = 4;
            this.rbLancha.TabStop = true;
            this.rbLancha.Text = "Lancha";
            this.rbLancha.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLancha);
            this.groupBox1.Controls.Add(this.rbHelicoptero);
            this.groupBox1.Controls.Add(this.rbCarro);
            this.groupBox1.Location = new System.Drawing.Point(110, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "opciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTexResultado);
            this.Controls.Add(this.btnReservar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.RichTextBox richTexResultado;
        private System.Windows.Forms.RadioButton rbCarro;
        private System.Windows.Forms.RadioButton rbHelicoptero;
        private System.Windows.Forms.RadioButton rbLancha;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

