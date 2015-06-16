namespace practica1
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nombreLibro = new System.Windows.Forms.TextBox();
            this.buscarLibro = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.estado = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Paginas = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Autor = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Tema = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Disponibles = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Reservados = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Prestdos = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del libro: ";
            // 
            // nombreLibro
            // 
            this.nombreLibro.Location = new System.Drawing.Point(109, 13);
            this.nombreLibro.Name = "nombreLibro";
            this.nombreLibro.Size = new System.Drawing.Size(191, 20);
            this.nombreLibro.TabIndex = 1;
            // 
            // buscarLibro
            // 
            this.buscarLibro.Location = new System.Drawing.Point(318, 9);
            this.buscarLibro.Name = "buscarLibro";
            this.buscarLibro.Size = new System.Drawing.Size(75, 23);
            this.buscarLibro.TabIndex = 2;
            this.buscarLibro.Text = "Buscar";
            this.buscarLibro.UseVisualStyleBackColor = true;
            this.buscarLibro.Click += new System.EventHandler(this.buscarLibro_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(13, 266);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 23);
            this.add.TabIndex = 4;
            this.add.Text = "Agregar Libro";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(202, 266);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(98, 23);
            this.addUser.TabIndex = 5;
            this.addUser.Text = "Usuario Nuevo";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(390, 266);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 6;
            this.show.Text = "Top Libros";
            this.show.UseVisualStyleBackColor = true;
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(543, 265);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(114, 23);
            this.estado.TabIndex = 7;
            this.estado.Text = "Cambio de Estado";
            this.estado.UseVisualStyleBackColor = true;
            this.estado.Click += new System.EventHandler(this.estado_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Existencia,
            this.Paginas,
            this.Autor,
            this.Tema,
            this.Disponibles,
            this.Reservados,
            this.Prestdos});
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // Paginas
            // 
            this.Paginas.HeaderText = "Paginas";
            this.Paginas.Name = "Paginas";
            this.Paginas.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Tema
            // 
            this.Tema.HeaderText = "Tema";
            this.Tema.Name = "Tema";
            this.Tema.ReadOnly = true;
            // 
            // Disponibles
            // 
            this.Disponibles.HeaderText = "Disponibles";
            this.Disponibles.Name = "Disponibles";
            this.Disponibles.ReadOnly = true;
            // 
            // Reservados
            // 
            this.Reservados.HeaderText = "Reservados";
            this.Reservados.Name = "Reservados";
            this.Reservados.ReadOnly = true;
            // 
            // Prestdos
            // 
            this.Prestdos.HeaderText = "Parestados";
            this.Prestdos.Name = "Prestdos";
            this.Prestdos.ReadOnly = true;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 313);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.show);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.add);
            this.Controls.Add(this.buscarLibro);
            this.Controls.Add(this.nombreLibro);
            this.Controls.Add(this.label1);
            this.Name = "inicio";
            this.Text = "BIBLIOTECA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreLibro;
        private System.Windows.Forms.Button buscarLibro;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button estado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn Nombre;
        private System.Windows.Forms.DataGridViewLinkColumn Existencia;
        private System.Windows.Forms.DataGridViewLinkColumn Paginas;
        private System.Windows.Forms.DataGridViewLinkColumn Autor;
        private System.Windows.Forms.DataGridViewLinkColumn Tema;
        private System.Windows.Forms.DataGridViewLinkColumn Disponibles;
        private System.Windows.Forms.DataGridViewLinkColumn Reservados;
        private System.Windows.Forms.DataGridViewLinkColumn Prestdos;
    }
}

