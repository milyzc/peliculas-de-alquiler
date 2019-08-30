namespace PeliculasDeAlquiler.Modulos.Directores
{
    partial class DirectoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoresForm));
            this.DgvDirectores = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDirectores)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDirectores
            // 
            this.DgvDirectores.AllowUserToAddRows = false;
            this.DgvDirectores.AllowUserToDeleteRows = false;
            this.DgvDirectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDirectores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Nacionalidad,
            this.FechaNacimiento});
            this.DgvDirectores.Location = new System.Drawing.Point(20, 92);
            this.DgvDirectores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvDirectores.MultiSelect = false;
            this.DgvDirectores.Name = "DgvDirectores";
            this.DgvDirectores.ReadOnly = true;
            this.DgvDirectores.RowTemplate.Height = 24;
            this.DgvDirectores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDirectores.Size = new System.Drawing.Size(647, 267);
            this.DgvDirectores.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
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
            this.BtnRefresh.Location = new System.Drawing.Point(620, 37);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(47, 50);
            this.BtnRefresh.TabIndex = 2;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
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
            this.BtnNuevo.Location = new System.Drawing.Point(564, 38);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(52, 48);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
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
            this.BtnEliminar.Location = new System.Drawing.Point(404, 38);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(52, 48);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(484, 62);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 5;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // DirectoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(686, 394);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DgvDirectores);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DirectoresForm";
            this.Text = "Directores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectoresForm_FormClosing);
            this.Load += new System.EventHandler(this.Directores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDirectores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDirectores;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.Button Modificar;
    }
}