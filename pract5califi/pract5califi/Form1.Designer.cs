namespace pract5califi
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
            this.labelC1 = new System.Windows.Forms.Label();
            this.labelC2 = new System.Windows.Forms.Label();
            this.labelC3 = new System.Windows.Forms.Label();
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.textBoxC3 = new System.Windows.Forms.TextBox();
            this.textBoxPro = new System.Windows.Forms.TextBox();
            this.labelEstatus = new System.Windows.Forms.Label();
            this.buttonPro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelC1
            // 
            this.labelC1.AutoSize = true;
            this.labelC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC1.Location = new System.Drawing.Point(26, 31);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(238, 20);
            this.labelC1.TabIndex = 0;
            this.labelC1.Text = "Ingrese la primera calificacion ";
            // 
            // labelC2
            // 
            this.labelC2.AutoSize = true;
            this.labelC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC2.Location = new System.Drawing.Point(25, 122);
            this.labelC2.Name = "labelC2";
            this.labelC2.Size = new System.Drawing.Size(239, 20);
            this.labelC2.TabIndex = 1;
            this.labelC2.Text = "Ingrese la segunda calificacion";
            // 
            // labelC3
            // 
            this.labelC3.AutoSize = true;
            this.labelC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC3.Location = new System.Drawing.Point(29, 227);
            this.labelC3.Name = "labelC3";
            this.labelC3.Size = new System.Drawing.Size(229, 20);
            this.labelC3.TabIndex = 2;
            this.labelC3.Text = "Ingrese la tersera calificacion";
            // 
            // textBoxC1
            // 
            this.textBoxC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC1.Location = new System.Drawing.Point(33, 78);
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.Size = new System.Drawing.Size(154, 27);
            this.textBoxC1.TabIndex = 3;
            // 
            // textBoxC2
            // 
            this.textBoxC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC2.Location = new System.Drawing.Point(33, 183);
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.Size = new System.Drawing.Size(154, 27);
            this.textBoxC2.TabIndex = 4;
            // 
            // textBoxC3
            // 
            this.textBoxC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC3.Location = new System.Drawing.Point(33, 279);
            this.textBoxC3.Name = "textBoxC3";
            this.textBoxC3.Size = new System.Drawing.Size(154, 27);
            this.textBoxC3.TabIndex = 5;
            // 
            // textBoxPro
            // 
            this.textBoxPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPro.Location = new System.Drawing.Point(438, 90);
            this.textBoxPro.Name = "textBoxPro";
            this.textBoxPro.Size = new System.Drawing.Size(100, 27);
            this.textBoxPro.TabIndex = 7;
            // 
            // labelEstatus
            // 
            this.labelEstatus.AutoSize = true;
            this.labelEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstatus.Location = new System.Drawing.Point(438, 138);
            this.labelEstatus.Name = "labelEstatus";
            this.labelEstatus.Size = new System.Drawing.Size(66, 20);
            this.labelEstatus.TabIndex = 8;
            this.labelEstatus.Text = "Estatus";
            // 
            // buttonPro
            // 
            this.buttonPro.Location = new System.Drawing.Point(442, 42);
            this.buttonPro.Name = "buttonPro";
            this.buttonPro.Size = new System.Drawing.Size(109, 30);
            this.buttonPro.TabIndex = 10;
            this.buttonPro.Text = "PROMEDIO";
            this.buttonPro.UseVisualStyleBackColor = true;
            this.buttonPro.Click += new System.EventHandler(this.buttonPro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPro);
            this.Controls.Add(this.labelEstatus);
            this.Controls.Add(this.textBoxPro);
            this.Controls.Add(this.textBoxC3);
            this.Controls.Add(this.textBoxC2);
            this.Controls.Add(this.textBoxC1);
            this.Controls.Add(this.labelC3);
            this.Controls.Add(this.labelC2);
            this.Controls.Add(this.labelC1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.Label labelC2;
        private System.Windows.Forms.Label labelC3;
        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.TextBox textBoxC3;
        private System.Windows.Forms.TextBox textBoxPro;
        private System.Windows.Forms.Label labelEstatus;
        private System.Windows.Forms.Button buttonPro;
    }
}

