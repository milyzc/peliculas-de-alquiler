namespace PeliculasDeAlquiler
{
    partial class ConsultarPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPeliculas));
            this.DgvPeliculas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLanzamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.CbGeneros = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPeliculas
            // 
            this.DgvPeliculas.AllowUserToAddRows = false;
            this.DgvPeliculas.AllowUserToDeleteRows = false;
            this.DgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Titulo,
            this.FechaLanzamiento,
            this.Genero,
            this.Director});
            this.DgvPeliculas.Location = new System.Drawing.Point(55, 303);
            this.DgvPeliculas.Name = "DgvPeliculas";
            this.DgvPeliculas.ReadOnly = true;
            this.DgvPeliculas.RowTemplate.Height = 24;
            this.DgvPeliculas.Size = new System.Drawing.Size(964, 368);
            this.DgvPeliculas.TabIndex = 0;
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
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Director
            // 
            this.Director.HeaderText = "Director";
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
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
            this.BtnRefresh.Location = new System.Drawing.Point(953, 234);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(66, 63);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // CbGeneros
            // 
            this.CbGeneros.FormattingEnabled = true;
            this.CbGeneros.Location = new System.Drawing.Point(55, 70);
            this.CbGeneros.Name = "CbGeneros";
            this.CbGeneros.Size = new System.Drawing.Size(215, 24);
            this.CbGeneros.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1097, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbGeneros);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DgvPeliculas);
            this.Name = "ConsultarPeliculas";
            this.Text = "Películas";
            this.Load += new System.EventHandler(this.ConsultarPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPeliculas;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLanzamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.ComboBox CbGeneros;
        private System.Windows.Forms.Button button1;
    }
}

