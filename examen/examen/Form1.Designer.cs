namespace examen
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
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.comboBoxDias = new System.Windows.Forms.ComboBox();
            this.buttonOPTENER = new System.Windows.Forms.Button();
            this.textBoxZodi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.BackColor = System.Drawing.Color.GreenYellow;
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Location = new System.Drawing.Point(52, 55);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMes.TabIndex = 0;
            this.comboBoxMes.SelectedIndexChanged += new System.EventHandler(this.comboBoxsig_SelectedIndexChanged);
            // 
            // comboBoxDias
            // 
            this.comboBoxDias.BackColor = System.Drawing.Color.GreenYellow;
            this.comboBoxDias.FormattingEnabled = true;
            this.comboBoxDias.Location = new System.Drawing.Point(363, 55);
            this.comboBoxDias.Name = "comboBoxDias";
            this.comboBoxDias.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDias.TabIndex = 1;
            // 
            // buttonOPTENER
            // 
            this.buttonOPTENER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOPTENER.Location = new System.Drawing.Point(173, 135);
            this.buttonOPTENER.Name = "buttonOPTENER";
            this.buttonOPTENER.Size = new System.Drawing.Size(158, 67);
            this.buttonOPTENER.TabIndex = 2;
            this.buttonOPTENER.Text = "Obtener signo zodiacal";
            this.buttonOPTENER.UseVisualStyleBackColor = true;
            this.buttonOPTENER.Click += new System.EventHandler(this.buttonOPTENER_Click);
            // 
            // textBoxZodi
            // 
            this.textBoxZodi.BackColor = System.Drawing.Color.Lime;
            this.textBoxZodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZodi.Location = new System.Drawing.Point(86, 299);
            this.textBoxZodi.Name = "textBoxZodi";
            this.textBoxZodi.Size = new System.Drawing.Size(371, 27);
            this.textBoxZodi.TabIndex = 3;
            this.textBoxZodi.TextChanged += new System.EventHandler(this.textBoxZodi_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.textBoxZodi);
            this.Controls.Add(this.buttonOPTENER);
            this.Controls.Add(this.comboBoxDias);
            this.Controls.Add(this.comboBoxMes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.ComboBox comboBoxDias;
        private System.Windows.Forms.Button buttonOPTENER;
        private System.Windows.Forms.TextBox textBoxZodi;
    }
}

