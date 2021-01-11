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
            this.rbCarro = new System.Windows.Forms.RadioButton();
            this.rbHelicoptero = new System.Windows.Forms.RadioButton();
            this.rbLancha = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbReserva = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInfoCarro = new System.Windows.Forms.Button();
            this.btnInfoHelicoptero = new System.Windows.Forms.Button();
            this.btnInfoLancha = new System.Windows.Forms.Button();
            this.rtInfoCarro = new System.Windows.Forms.RichTextBox();
            this.rtInfoHelicoptero = new System.Windows.Forms.RichTextBox();
            this.rtInfoLancha = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(134, 409);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 0;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // rbCarro
            // 
            this.rbCarro.AutoSize = true;
            this.rbCarro.Location = new System.Drawing.Point(85, 33);
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
            this.rbHelicoptero.Location = new System.Drawing.Point(232, 33);
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
            this.rbLancha.Location = new System.Drawing.Point(427, 33);
            this.rbLancha.Name = "rbLancha";
            this.rbLancha.Size = new System.Drawing.Size(61, 17);
            this.rbLancha.TabIndex = 4;
            this.rbLancha.TabStop = true;
            this.rbLancha.Text = "Lancha";
            this.rbLancha.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtInfoLancha);
            this.groupBox1.Controls.Add(this.rtInfoHelicoptero);
            this.groupBox1.Controls.Add(this.rtInfoCarro);
            this.groupBox1.Controls.Add(this.btnInfoCarro);
            this.groupBox1.Controls.Add(this.btnInfoHelicoptero);
            this.groupBox1.Controls.Add(this.btnInfoLancha);
            this.groupBox1.Controls.Add(this.rbLancha);
            this.groupBox1.Controls.Add(this.rbHelicoptero);
            this.groupBox1.Controls.Add(this.rbCarro);
            this.groupBox1.Location = new System.Drawing.Point(114, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 320);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "opciones";
            // 
            // tbReserva
            // 
            this.tbReserva.Location = new System.Drawing.Point(234, 412);
            this.tbReserva.Name = "tbReserva";
            this.tbReserva.Size = new System.Drawing.Size(427, 20);
            this.tbReserva.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(134, 438);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInfoCarro
            // 
            this.btnInfoCarro.Location = new System.Drawing.Point(60, 73);
            this.btnInfoCarro.Name = "btnInfoCarro";
            this.btnInfoCarro.Size = new System.Drawing.Size(75, 54);
            this.btnInfoCarro.TabIndex = 8;
            this.btnInfoCarro.Text = "Mostrar informacion de Carro";
            this.btnInfoCarro.UseVisualStyleBackColor = true;
            this.btnInfoCarro.Click += new System.EventHandler(this.btnInfoCarro_Click);
            // 
            // btnInfoHelicoptero
            // 
            this.btnInfoHelicoptero.Location = new System.Drawing.Point(232, 73);
            this.btnInfoHelicoptero.Name = "btnInfoHelicoptero";
            this.btnInfoHelicoptero.Size = new System.Drawing.Size(96, 54);
            this.btnInfoHelicoptero.TabIndex = 9;
            this.btnInfoHelicoptero.Text = "Mostrar informacion de Helicoptero";
            this.btnInfoHelicoptero.UseVisualStyleBackColor = true;
            this.btnInfoHelicoptero.Click += new System.EventHandler(this.btnInfoHelicoptero_Click);
            // 
            // btnInfoLancha
            // 
            this.btnInfoLancha.Location = new System.Drawing.Point(427, 73);
            this.btnInfoLancha.Name = "btnInfoLancha";
            this.btnInfoLancha.Size = new System.Drawing.Size(75, 54);
            this.btnInfoLancha.TabIndex = 10;
            this.btnInfoLancha.Text = "Mostrar informacion de Lancha";
            this.btnInfoLancha.UseVisualStyleBackColor = true;
            this.btnInfoLancha.Click += new System.EventHandler(this.btnInfoLancha_Click);
            // 
            // rtInfoCarro
            // 
            this.rtInfoCarro.Location = new System.Drawing.Point(20, 133);
            this.rtInfoCarro.Name = "rtInfoCarro";
            this.rtInfoCarro.Size = new System.Drawing.Size(164, 153);
            this.rtInfoCarro.TabIndex = 11;
            this.rtInfoCarro.Text = "";
            // 
            // rtInfoHelicoptero
            // 
            this.rtInfoHelicoptero.Location = new System.Drawing.Point(207, 133);
            this.rtInfoHelicoptero.Name = "rtInfoHelicoptero";
            this.rtInfoHelicoptero.Size = new System.Drawing.Size(164, 153);
            this.rtInfoHelicoptero.TabIndex = 12;
            this.rtInfoHelicoptero.Text = "";
            // 
            // rtInfoLancha
            // 
            this.rtInfoLancha.Location = new System.Drawing.Point(396, 133);
            this.rtInfoLancha.Name = "rtInfoLancha";
            this.rtInfoLancha.Size = new System.Drawing.Size(164, 153);
            this.rtInfoLancha.TabIndex = 13;
            this.rtInfoLancha.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 534);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tbReserva);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReservar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.RadioButton rbCarro;
        private System.Windows.Forms.RadioButton rbHelicoptero;
        private System.Windows.Forms.RadioButton rbLancha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbReserva;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox rtInfoLancha;
        private System.Windows.Forms.RichTextBox rtInfoHelicoptero;
        private System.Windows.Forms.RichTextBox rtInfoCarro;
        private System.Windows.Forms.Button btnInfoCarro;
        private System.Windows.Forms.Button btnInfoHelicoptero;
        private System.Windows.Forms.Button btnInfoLancha;
    }
}

