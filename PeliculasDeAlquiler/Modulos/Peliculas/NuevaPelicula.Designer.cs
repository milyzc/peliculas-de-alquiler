namespace PeliculasDeAlquiler.Modulos.Peliculas
{
    partial class NuevaPeliculaForm
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
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbGeneros = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LtbDirectores = new System.Windows.Forms.ListBox();
            this.TxtDirector = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnQuitarSeleccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(193, 46);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(435, 22);
            this.TxtTitulo.TabIndex = 3;
            this.TxtTitulo.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(128, 49);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(43, 17);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Título";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblTitulo.Click += new System.EventHandler(this.LblNombre_Click);
            // 
            // DtpFechaLanzamiento
            // 
            this.DtpFechaLanzamiento.CustomFormat = "dd/MM/yyyy";
            this.DtpFechaLanzamiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DtpFechaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaLanzamiento.Location = new System.Drawing.Point(193, 123);
            this.DtpFechaLanzamiento.Name = "DtpFechaLanzamiento";
            this.DtpFechaLanzamiento.Size = new System.Drawing.Size(200, 22);
            this.DtpFechaLanzamiento.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de lanzamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CmbGeneros
            // 
            this.CmbGeneros.FormattingEnabled = true;
            this.CmbGeneros.Location = new System.Drawing.Point(193, 197);
            this.CmbGeneros.Name = "CmbGeneros";
            this.CmbGeneros.Size = new System.Drawing.Size(200, 24);
            this.CmbGeneros.TabIndex = 7;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.Location = new System.Drawing.Point(497, 436);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(131, 56);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSize = true;
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Location = new System.Drawing.Point(352, 436);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(131, 56);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LtbDirectores
            // 
            this.LtbDirectores.FormattingEnabled = true;
            this.LtbDirectores.ItemHeight = 16;
            this.LtbDirectores.Location = new System.Drawing.Point(193, 306);
            this.LtbDirectores.Name = "LtbDirectores";
            this.LtbDirectores.Size = new System.Drawing.Size(435, 100);
            this.LtbDirectores.TabIndex = 10;
            this.LtbDirectores.SelectedIndexChanged += new System.EventHandler(this.LtbDirectores_SelectedIndexChanged);
            // 
            // TxtDirector
            // 
            this.TxtDirector.Location = new System.Drawing.Point(193, 261);
            this.TxtDirector.Name = "TxtDirector";
            this.TxtDirector.Size = new System.Drawing.Size(391, 22);
            this.TxtDirector.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Director";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.BtnQuitarSeleccion.Location = new System.Drawing.Point(590, 261);
            this.BtnQuitarSeleccion.Name = "BtnQuitarSeleccion";
            this.BtnQuitarSeleccion.Size = new System.Drawing.Size(37, 22);
            this.BtnQuitarSeleccion.TabIndex = 13;
            this.BtnQuitarSeleccion.TabStop = false;
            this.BtnQuitarSeleccion.Text = "X";
            this.BtnQuitarSeleccion.UseVisualStyleBackColor = false;
            this.BtnQuitarSeleccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // NuevaPeliculaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(655, 513);
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
            this.Name = "NuevaPeliculaForm";
            this.Text = "Nueva Película";
            this.Load += new System.EventHandler(this.NuevaPeliculaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DateTimePicker DtpFechaLanzamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbGeneros;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ListBox LtbDirectores;
        private System.Windows.Forms.TextBox TxtDirector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnQuitarSeleccion;
    }
}