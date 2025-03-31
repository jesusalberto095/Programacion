namespace poke
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNOM = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelTIPO1 = new System.Windows.Forms.Label();
            this.labelTIPO2 = new System.Windows.Forms.Label();
            this.labelDES = new System.Windows.Forms.Label();
            this.buttonSIG = new System.Windows.Forms.Button();
            this.buttonANTE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(206, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNOM
            // 
            this.labelNOM.BackColor = System.Drawing.Color.LightGreen;
            this.labelNOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOM.Location = new System.Drawing.Point(535, 173);
            this.labelNOM.Name = "labelNOM";
            this.labelNOM.Size = new System.Drawing.Size(86, 26);
            this.labelNOM.TabIndex = 1;
            this.labelNOM.Text = "label1";
            // 
            // labelID
            // 
            this.labelID.BackColor = System.Drawing.Color.LightGreen;
            this.labelID.Location = new System.Drawing.Point(479, 173);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(46, 23);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "label1";
            // 
            // labelTIPO1
            // 
            this.labelTIPO1.BackColor = System.Drawing.Color.LightGreen;
            this.labelTIPO1.Location = new System.Drawing.Point(464, 220);
            this.labelTIPO1.Name = "labelTIPO1";
            this.labelTIPO1.Size = new System.Drawing.Size(71, 23);
            this.labelTIPO1.TabIndex = 3;
            this.labelTIPO1.Text = "label1";
            // 
            // labelTIPO2
            // 
            this.labelTIPO2.BackColor = System.Drawing.Color.LightGreen;
            this.labelTIPO2.Location = new System.Drawing.Point(541, 220);
            this.labelTIPO2.Name = "labelTIPO2";
            this.labelTIPO2.Size = new System.Drawing.Size(80, 23);
            this.labelTIPO2.TabIndex = 4;
            this.labelTIPO2.Text = "label1";
            // 
            // labelDES
            // 
            this.labelDES.BackColor = System.Drawing.Color.LightGreen;
            this.labelDES.Location = new System.Drawing.Point(464, 264);
            this.labelDES.Name = "labelDES";
            this.labelDES.Size = new System.Drawing.Size(153, 80);
            this.labelDES.TabIndex = 5;
            this.labelDES.Text = "label1";
            // 
            // buttonSIG
            // 
            this.buttonSIG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSIG.Location = new System.Drawing.Point(544, 347);
            this.buttonSIG.Name = "buttonSIG";
            this.buttonSIG.Size = new System.Drawing.Size(88, 42);
            this.buttonSIG.TabIndex = 6;
            this.buttonSIG.Text = "SIGUIENTE";
            this.buttonSIG.UseVisualStyleBackColor = false;
            this.buttonSIG.Click += new System.EventHandler(this.buttonSIG_Click);
            // 
            // buttonANTE
            // 
            this.buttonANTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonANTE.Location = new System.Drawing.Point(452, 347);
            this.buttonANTE.Name = "buttonANTE";
            this.buttonANTE.Size = new System.Drawing.Size(86, 42);
            this.buttonANTE.TabIndex = 7;
            this.buttonANTE.Text = "ANTERIOR";
            this.buttonANTE.UseVisualStyleBackColor = false;
            this.buttonANTE.Click += new System.EventHandler(this.buttonANTE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.buttonANTE);
            this.Controls.Add(this.buttonSIG);
            this.Controls.Add(this.labelDES);
            this.Controls.Add(this.labelTIPO2);
            this.Controls.Add(this.labelTIPO1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelNOM);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNOM;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelTIPO1;
        private System.Windows.Forms.Label labelTIPO2;
        private System.Windows.Forms.Label labelDES;
        private System.Windows.Forms.Button buttonSIG;
        private System.Windows.Forms.Button buttonANTE;
    }
}

