namespace PeliculasDeAlquiler.Modulos.Alquileres
{
    partial class NuevoAlquilerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblFechaHoy = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblCliente = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.DvgPeliculasSeleccionadas = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DgvPeliculas = new System.Windows.Forms.DataGridView();
            this.CodigoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLanzamientoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroIdP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitarioP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLanzamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DvgPeliculasSeleccionadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "TOTAL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(90, 559);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(120, 22);
            this.TxtTotal.TabIndex = 21;
            // 
            // LblFechaHoy
            // 
            this.LblFechaHoy.AutoSize = true;
            this.LblFechaHoy.Location = new System.Drawing.Point(158, 28);
            this.LblFechaHoy.Name = "LblFechaHoy";
            this.LblFechaHoy.Size = new System.Drawing.Size(0, 17);
            this.LblFechaHoy.TabIndex = 20;
            this.LblFechaHoy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(26, 28);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(92, 17);
            this.LblFecha.TabIndex = 19;
            this.LblFecha.Text = "Fecha Desde";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.Location = new System.Drawing.Point(844, 525);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(131, 56);
            this.BtnCancelar.TabIndex = 18;
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
            this.BtnGuardar.Location = new System.Drawing.Point(699, 525);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(131, 56);
            this.BtnGuardar.TabIndex = 17;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(26, 72);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(51, 17);
            this.LblCliente.TabIndex = 16;
            this.LblCliente.Text = "Cliente";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(161, 72);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(428, 22);
            this.TxtCliente.TabIndex = 15;
            // 
            // DvgPeliculasSeleccionadas
            // 
            this.DvgPeliculasSeleccionadas.AllowUserToAddRows = false;
            this.DvgPeliculasSeleccionadas.AllowUserToDeleteRows = false;
            this.DvgPeliculasSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgPeliculasSeleccionadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Titulo,
            this.FechaLanzamiento,
            this.Genero,
            this.GeneroId,
            this.PrecioUnitario,
            this.Stock,
            this.Subtotal,
            this.Observaciones});
            this.DvgPeliculasSeleccionadas.Location = new System.Drawing.Point(538, 110);
            this.DvgPeliculasSeleccionadas.Name = "DvgPeliculasSeleccionadas";
            this.DvgPeliculasSeleccionadas.RowTemplate.Height = 24;
            this.DvgPeliculasSeleccionadas.Size = new System.Drawing.Size(483, 402);
            this.DvgPeliculasSeleccionadas.TabIndex = 23;
            this.DvgPeliculasSeleccionadas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgPeliculasSeleccionadas_CellEndEdit);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.AutoSize = true;
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.Location = new System.Drawing.Point(483, 249);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(52, 40);
            this.BtnAgregar.TabIndex = 24;
            this.BtnAgregar.Text = "+";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Location = new System.Drawing.Point(483, 301);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(52, 43);
            this.BtnEliminar.TabIndex = 25;
            this.BtnEliminar.Text = "-";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // DgvPeliculas
            // 
            this.DgvPeliculas.AllowUserToAddRows = false;
            this.DgvPeliculas.AllowUserToDeleteRows = false;
            this.DgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoP,
            this.TituloP,
            this.FechaLanzamientoP,
            this.GeneroP,
            this.GeneroIdP,
            this.PrecioUnitarioP,
            this.StockP,
            this.CantidadP,
            this.SubtotalP});
            this.DgvPeliculas.Location = new System.Drawing.Point(12, 110);
            this.DgvPeliculas.Name = "DgvPeliculas";
            this.DgvPeliculas.RowTemplate.Height = 24;
            this.DgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPeliculas.Size = new System.Drawing.Size(464, 402);
            this.DgvPeliculas.TabIndex = 26;
            // 
            // CodigoP
            // 
            this.CodigoP.HeaderText = "Código";
            this.CodigoP.Name = "CodigoP";
            this.CodigoP.ReadOnly = true;
            this.CodigoP.Visible = false;
            // 
            // TituloP
            // 
            this.TituloP.HeaderText = "Título";
            this.TituloP.Name = "TituloP";
            this.TituloP.ReadOnly = true;
            // 
            // FechaLanzamientoP
            // 
            this.FechaLanzamientoP.HeaderText = "Fecha de lanzamiento";
            this.FechaLanzamientoP.Name = "FechaLanzamientoP";
            this.FechaLanzamientoP.ReadOnly = true;
            this.FechaLanzamientoP.Visible = false;
            // 
            // GeneroP
            // 
            this.GeneroP.HeaderText = "Genero";
            this.GeneroP.Name = "GeneroP";
            this.GeneroP.ReadOnly = true;
            this.GeneroP.Visible = false;
            // 
            // GeneroIdP
            // 
            this.GeneroIdP.HeaderText = "GeneroId";
            this.GeneroIdP.Name = "GeneroIdP";
            this.GeneroIdP.ReadOnly = true;
            this.GeneroIdP.Visible = false;
            // 
            // PrecioUnitarioP
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.PrecioUnitarioP.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrecioUnitarioP.HeaderText = "Precio unitario";
            this.PrecioUnitarioP.Name = "PrecioUnitarioP";
            this.PrecioUnitarioP.ReadOnly = true;
            // 
            // StockP
            // 
            this.StockP.HeaderText = "Stock";
            this.StockP.Name = "StockP";
            this.StockP.ReadOnly = true;
            // 
            // CantidadP
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.CantidadP.DefaultCellStyle = dataGridViewCellStyle4;
            this.CantidadP.HeaderText = "Cantidad";
            this.CantidadP.Name = "CantidadP";
            this.CantidadP.Visible = false;
            // 
            // SubtotalP
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.SubtotalP.DefaultCellStyle = dataGridViewCellStyle5;
            this.SubtotalP.HeaderText = "Subtotal";
            this.SubtotalP.Name = "SubtotalP";
            this.SubtotalP.ReadOnly = true;
            this.SubtotalP.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha Hasta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DtpFechaHasta
            // 
            this.DtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaHasta.Location = new System.Drawing.Point(671, 28);
            this.DtpFechaHasta.Name = "DtpFechaHasta";
            this.DtpFechaHasta.Size = new System.Drawing.Size(200, 22);
            this.DtpFechaHasta.TabIndex = 28;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // FechaLanzamiento
            // 
            this.FechaLanzamiento.HeaderText = "Fecha de lanzamiento";
            this.FechaLanzamiento.Name = "FechaLanzamiento";
            this.FechaLanzamiento.ReadOnly = true;
            this.FechaLanzamiento.Visible = false;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Visible = false;
            // 
            // GeneroId
            // 
            this.GeneroId.HeaderText = "GeneroId";
            this.GeneroId.Name = "GeneroId";
            this.GeneroId.ReadOnly = true;
            this.GeneroId.Visible = false;
            // 
            // PrecioUnitario
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrecioUnitario.HeaderText = "Precio unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Visible = false;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Visible = false;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            // 
            // NuevoAlquilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1033, 603);
            this.Controls.Add(this.DtpFechaHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvPeliculas);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DvgPeliculasSeleccionadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.LblFechaHoy);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.TxtCliente);
            this.Name = "NuevoAlquilerForm";
            this.Text = "NuevoAlquilerForm";
            this.Load += new System.EventHandler(this.NuevoAlquilerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgPeliculasSeleccionadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblFechaHoy;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.DataGridView DvgPeliculasSeleccionadas;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView DgvPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLanzamientoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroIdP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitarioP;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLanzamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}