namespace PeliculasDeAlquiler.Modulos.Directores
{
    partial class ModificarDir
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNac = new System.Windows.Forms.TextBox();
            this.fecNac = new System.Windows.Forms.DateTimePicker();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNac = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 90);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 28);
            this.txtName.TabIndex = 0;
            // 
            // txtNac
            // 
            this.txtNac.Location = new System.Drawing.Point(12, 165);
            this.txtNac.Multiline = true;
            this.txtNac.Name = "txtNac";
            this.txtNac.Size = new System.Drawing.Size(370, 28);
            this.txtNac.TabIndex = 1;
            // 
            // fecNac
            // 
            this.fecNac.Location = new System.Drawing.Point(12, 247);
            this.fecNac.Name = "fecNac";
            this.fecNac.Size = new System.Drawing.Size(370, 20);
            this.fecNac.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 74);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nombre";
            // 
            // lblNac
            // 
            this.lblNac.AutoSize = true;
            this.lblNac.Location = new System.Drawing.Point(9, 149);
            this.lblNac.Name = "lblNac";
            this.lblNac.Size = new System.Drawing.Size(69, 13);
            this.lblNac.TabIndex = 4;
            this.lblNac.Text = "Nacionalidad";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 231);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(106, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Fecha de nacimiento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModificarDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(490, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNac);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.fecNac);
            this.Controls.Add(this.txtNac);
            this.Controls.Add(this.txtName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ModificarDir";
            this.Text = "EliminarDir";
            this.Load += new System.EventHandler(this.ModificarDir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNac;
        private System.Windows.Forms.DateTimePicker fecNac;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNac;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}