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
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.lblFechaHoy = new System.Windows.Forms.Label();
            this.dgvPeliculasSeleccionadas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.codigoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLanzamientoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoIdP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLanzamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculasSeleccionadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoP,
            this.tituloP,
            this.fechaLanzamientoP,
            this.generoP,
            this.generoIdP,
            this.precioUnitarioP,
            this.stockP,
            this.cantidadP,
            this.subtotalP});
            this.dgvPeliculas.Location = new System.Drawing.Point(12, 69);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.Size = new System.Drawing.Size(317, 294);
            this.dgvPeliculas.TabIndex = 0;
            // 
            // lblFechaHoy
            // 
            this.lblFechaHoy.AutoSize = true;
            this.lblFechaHoy.Location = new System.Drawing.Point(9, 12);
            this.lblFechaHoy.Name = "lblFechaHoy";
            this.lblFechaHoy.Size = new System.Drawing.Size(71, 13);
            this.lblFechaHoy.TabIndex = 1;
            this.lblFechaHoy.Text = "Fecha Desde";
            // 
            // dgvPeliculasSeleccionadas
            // 
            this.dgvPeliculasSeleccionadas.AllowUserToAddRows = false;
            this.dgvPeliculasSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculasSeleccionadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.titulo,
            this.fechaLanzamiento,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvPeliculasSeleccionadas.Location = new System.Drawing.Point(375, 69);
            this.dgvPeliculasSeleccionadas.Name = "dgvPeliculasSeleccionadas";
            this.dgvPeliculasSeleccionadas.Size = new System.Drawing.Size(330, 294);
            this.dgvPeliculasSeleccionadas.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(65, 43);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(316, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(471, 12);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(57, 369);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // codigoP
            // 
            this.codigoP.HeaderText = "Código";
            this.codigoP.Name = "codigoP";
            this.codigoP.Visible = false;
            // 
            // tituloP
            // 
            this.tituloP.HeaderText = "Titulo";
            this.tituloP.Name = "tituloP";
            // 
            // fechaLanzamientoP
            // 
            this.fechaLanzamientoP.HeaderText = "Fecha de lanzamiento";
            this.fechaLanzamientoP.Name = "fechaLanzamientoP";
            this.fechaLanzamientoP.Visible = false;
            // 
            // generoP
            // 
            this.generoP.HeaderText = "Genero";
            this.generoP.Name = "generoP";
            this.generoP.Visible = false;
            // 
            // generoIdP
            // 
            this.generoIdP.HeaderText = "GeneroId";
            this.generoIdP.Name = "generoIdP";
            this.generoIdP.Visible = false;
            // 
            // precioUnitarioP
            // 
            this.precioUnitarioP.HeaderText = "Precio unitario";
            this.precioUnitarioP.Name = "precioUnitarioP";
            // 
            // stockP
            // 
            this.stockP.HeaderText = "Stock";
            this.stockP.Name = "stockP";
            // 
            // cantidadP
            // 
            this.cantidadP.HeaderText = "Cantidad";
            this.cantidadP.Name = "cantidadP";
            this.cantidadP.Visible = false;
            // 
            // subtotalP
            // 
            this.subtotalP.HeaderText = "Subtotal";
            this.subtotalP.Name = "subtotalP";
            this.subtotalP.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(335, 151);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(34, 32);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Visible = false;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            // 
            // fechaLanzamiento
            // 
            this.fechaLanzamiento.HeaderText = "Fecha de lanzamiento";
            this.fechaLanzamiento.Name = "fechaLanzamiento";
            this.fechaLanzamiento.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "GeneroId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio unitario";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(630, 369);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // NuevoAlquilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 394);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPeliculasSeleccionadas);
            this.Controls.Add(this.lblFechaHoy);
            this.Controls.Add(this.dgvPeliculas);
            this.Name = "NuevoAlquilerForm";
            this.Text = "NuevoAlquilerForm";
            this.Load += new System.EventHandler(this.NuevoAlquilerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculasSeleccionadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Label lblFechaHoy;
        private System.Windows.Forms.DataGridView dgvPeliculasSeleccionadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloP;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLanzamientoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoIdP;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioP;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadP;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalP;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLanzamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnGuardar;
    }
}