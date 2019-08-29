namespace PeliculasDeAlquiler.Modulos.Directores
{
    partial class frmCargaDirector
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
            this.dtpFechaDirector = new System.Windows.Forms.DateTimePicker();
            this.txtNombreDirector = new System.Windows.Forms.TextBox();
            this.txtNacionalidadDirector = new System.Windows.Forms.TextBox();
            this.lblNombreDirector = new System.Windows.Forms.Label();
            this.lblApellidoDirector = new System.Windows.Forms.Label();
            this.lblFechaNacDir = new System.Windows.Forms.Label();
            this.btnCargarDirector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaDirector
            // 
            this.dtpFechaDirector.Location = new System.Drawing.Point(166, 142);
            this.dtpFechaDirector.Name = "dtpFechaDirector";
            this.dtpFechaDirector.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDirector.TabIndex = 0;
            // 
            // txtNombreDirector
            // 
            this.txtNombreDirector.Location = new System.Drawing.Point(115, 50);
            this.txtNombreDirector.Name = "txtNombreDirector";
            this.txtNombreDirector.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDirector.TabIndex = 1;
            // 
            // txtNacionalidadDirector
            // 
            this.txtNacionalidadDirector.Location = new System.Drawing.Point(115, 90);
            this.txtNacionalidadDirector.Name = "txtNacionalidadDirector";
            this.txtNacionalidadDirector.Size = new System.Drawing.Size(100, 20);
            this.txtNacionalidadDirector.TabIndex = 2;
            // 
            // lblNombreDirector
            // 
            this.lblNombreDirector.AutoSize = true;
            this.lblNombreDirector.Location = new System.Drawing.Point(37, 53);
            this.lblNombreDirector.Name = "lblNombreDirector";
            this.lblNombreDirector.Size = new System.Drawing.Size(47, 13);
            this.lblNombreDirector.TabIndex = 3;
            this.lblNombreDirector.Text = "Nombre:";
            // 
            // lblApellidoDirector
            // 
            this.lblApellidoDirector.AutoSize = true;
            this.lblApellidoDirector.Location = new System.Drawing.Point(37, 93);
            this.lblApellidoDirector.Name = "lblApellidoDirector";
            this.lblApellidoDirector.Size = new System.Drawing.Size(72, 13);
            this.lblApellidoDirector.TabIndex = 4;
            this.lblApellidoDirector.Text = "Nacionalidad:";
            // 
            // lblFechaNacDir
            // 
            this.lblFechaNacDir.AutoSize = true;
            this.lblFechaNacDir.Location = new System.Drawing.Point(37, 142);
            this.lblFechaNacDir.Name = "lblFechaNacDir";
            this.lblFechaNacDir.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacDir.TabIndex = 5;
            this.lblFechaNacDir.Text = "Fecha de Nacimiento:";
            // 
            // btnCargarDirector
            // 
            this.btnCargarDirector.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarDirector.Location = new System.Drawing.Point(40, 206);
            this.btnCargarDirector.Name = "btnCargarDirector";
            this.btnCargarDirector.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDirector.TabIndex = 6;
            this.btnCargarDirector.Text = "Cargar";
            this.btnCargarDirector.UseVisualStyleBackColor = true;
            this.btnCargarDirector.Click += new System.EventHandler(this.btnCargarDirector_Click);
            // 
            // frmCargaDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 280);
            this.Controls.Add(this.btnCargarDirector);
            this.Controls.Add(this.lblFechaNacDir);
            this.Controls.Add(this.lblApellidoDirector);
            this.Controls.Add(this.lblNombreDirector);
            this.Controls.Add(this.txtNacionalidadDirector);
            this.Controls.Add(this.txtNombreDirector);
            this.Controls.Add(this.dtpFechaDirector);
            this.Name = "frmCargaDirector";
            this.Text = "Nuevo director";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDirector;
        private System.Windows.Forms.TextBox txtNombreDirector;
        private System.Windows.Forms.TextBox txtNacionalidadDirector;
        private System.Windows.Forms.Label lblNombreDirector;
        private System.Windows.Forms.Label lblApellidoDirector;
        private System.Windows.Forms.Label lblFechaNacDir;
        private System.Windows.Forms.Button btnCargarDirector;
    }
}