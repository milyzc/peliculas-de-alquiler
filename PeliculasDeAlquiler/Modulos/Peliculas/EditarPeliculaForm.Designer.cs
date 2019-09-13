namespace PeliculasDeAlquiler.Modulos.Peliculas
{
    partial class EditarPeliculaForm
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
            this.BtnQuitarSeleccion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDirector = new System.Windows.Forms.TextBox();
            this.LtbDirectores = new System.Windows.Forms.ListBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CmbGeneros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnQuitarSeleccion
            // 
            this.BtnQuitarSeleccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnQuitarSeleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuitarSeleccion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnQuitarSeleccion.FlatAppearance.BorderSize = 0;
            this.BtnQuitarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitarSeleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnQuitarSeleccion.Location = new System.Drawing.Point(576, 237);
            this.BtnQuitarSeleccion.Name = "BtnQuitarSeleccion";
            this.BtnQuitarSeleccion.Size = new System.Drawing.Size(37, 22);
            this.BtnQuitarSeleccion.TabIndex = 25;
            this.BtnQuitarSeleccion.TabStop = false;
            this.BtnQuitarSeleccion.Text = "X";
            this.BtnQuitarSeleccion.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Director";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtDirector
            // 
            this.TxtDirector.Location = new System.Drawing.Point(179, 237);
            this.TxtDirector.Name = "TxtDirector";
            this.TxtDirector.Size = new System.Drawing.Size(391, 22);
            this.TxtDirector.TabIndex = 23;
            // 
            // LtbDirectores
            // 
            this.LtbDirectores.FormattingEnabled = true;
            this.LtbDirectores.ItemHeight = 16;
            this.LtbDirectores.Location = new System.Drawing.Point(179, 282);
            this.LtbDirectores.Name = "LtbDirectores";
            this.LtbDirectores.Size = new System.Drawing.Size(435, 100);
            this.LtbDirectores.TabIndex = 22;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.Location = new System.Drawing.Point(483, 412);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(131, 56);
            this.BtnCancelar.TabIndex = 21;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSize = true;
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Location = new System.Drawing.Point(338, 412);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(131, 56);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // CmbGeneros
            // 
            this.CmbGeneros.FormattingEnabled = true;
            this.CmbGeneros.Location = new System.Drawing.Point(179, 173);
            this.CmbGeneros.Name = "CmbGeneros";
            this.CmbGeneros.Size = new System.Drawing.Size(200, 24);
            this.CmbGeneros.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Genero";
            // 
            // DtpFechaLanzamiento
            // 
            this.DtpFechaLanzamiento.CustomFormat = "dd/MM/yyyy";
            this.DtpFechaLanzamiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DtpFechaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaLanzamiento.Location = new System.Drawing.Point(179, 100);
            this.DtpFechaLanzamiento.Name = "DtpFechaLanzamiento";
            this.DtpFechaLanzamiento.Size = new System.Drawing.Size(200, 22);
            this.DtpFechaLanzamiento.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha de lanzamiento";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(179, 22);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(435, 22);
            this.TxtTitulo.TabIndex = 15;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(114, 25);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(43, 17);
            this.LblTitulo.TabIndex = 14;
            this.LblTitulo.Text = "Título";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditarPeliculaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(641, 492);
            this.Controls.Add(this.BtnQuitarSeleccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDirector);
            this.Controls.Add(this.LtbDirectores);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CmbGeneros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpFechaLanzamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.LblTitulo);
            this.Name = "EditarPeliculaForm";
            this.Text = "EditarPeliculaForm";
            this.Load += new System.EventHandler(this.EditarPeliculaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnQuitarSeleccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDirector;
        private System.Windows.Forms.ListBox LtbDirectores;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CmbGeneros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaLanzamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label LblTitulo;
    }
}