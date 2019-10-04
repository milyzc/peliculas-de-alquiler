namespace PeliculasDeAlquiler.Modulos.Alquileres
{
    partial class AlquileresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlquileresForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditar.BackgroundImage")));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEditar.Location = new System.Drawing.Point(705, 14);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(63, 61);
            this.BtnEditar.TabIndex = 14;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Location = new System.Drawing.Point(565, 14);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(69, 59);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.BackgroundImage")));
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ForeColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.Location = new System.Drawing.Point(629, 14);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(71, 59);
            this.BtnNuevo.TabIndex = 12;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.BackgroundImage")));
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.Location = new System.Drawing.Point(774, 13);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(63, 61);
            this.BtnRefresh.TabIndex = 11;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // DgvVentas
            // 
            this.DgvVentas.AllowUserToAddRows = false;
            this.DgvVentas.AllowUserToDeleteRows = false;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cliente,
            this.Fecha,
            this.FechaHasta,
            this.Monto});
            this.DgvVentas.Location = new System.Drawing.Point(12, 81);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.ReadOnly = true;
            this.DgvVentas.RowTemplate.Height = 24;
            this.DgvVentas.Size = new System.Drawing.Size(828, 357);
            this.DgvVentas.TabIndex = 10;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Fecha
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle4;
            this.Fecha.HeaderText = "Fecha desde";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // FechaHasta
            // 
            this.FechaHasta.HeaderText = "FechaHasta";
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto ($)";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // AlquileresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(847, 449);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DgvVentas);
            this.Name = "AlquileresForm";
            this.Text = "AlquileresForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlquileresForm_FormClosing);
            this.Load += new System.EventHandler(this.AlquileresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}