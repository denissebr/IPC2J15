namespace practica1
{
    partial class agregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreLibro = new System.Windows.Forms.TextBox();
            this.existencia = new System.Windows.Forms.TextBox();
            this.paginas = new System.Windows.Forms.TextBox();
            this.tema = new System.Windows.Forms.TextBox();
            this.autor = new System.Windows.Forms.TextBox();
            this.addL = new System.Windows.Forms.Button();
            this.inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombe del Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Existencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Paginas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tema";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre del Autor";
            // 
            // nombreLibro
            // 
            this.nombreLibro.Location = new System.Drawing.Point(153, 13);
            this.nombreLibro.Name = "nombreLibro";
            this.nombreLibro.Size = new System.Drawing.Size(159, 20);
            this.nombreLibro.TabIndex = 5;
            // 
            // existencia
            // 
            this.existencia.Location = new System.Drawing.Point(153, 44);
            this.existencia.Name = "existencia";
            this.existencia.Size = new System.Drawing.Size(159, 20);
            this.existencia.TabIndex = 6;
            // 
            // paginas
            // 
            this.paginas.Location = new System.Drawing.Point(153, 74);
            this.paginas.Name = "paginas";
            this.paginas.Size = new System.Drawing.Size(159, 20);
            this.paginas.TabIndex = 7;
            // 
            // tema
            // 
            this.tema.Location = new System.Drawing.Point(153, 112);
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(159, 20);
            this.tema.TabIndex = 8;
            // 
            // autor
            // 
            this.autor.Location = new System.Drawing.Point(153, 144);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(159, 20);
            this.autor.TabIndex = 9;
            // 
            // addL
            // 
            this.addL.Location = new System.Drawing.Point(19, 195);
            this.addL.Name = "addL";
            this.addL.Size = new System.Drawing.Size(75, 23);
            this.addL.TabIndex = 10;
            this.addL.Text = "Agregar";
            this.addL.UseVisualStyleBackColor = true;
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(237, 195);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(75, 23);
            this.inicio.TabIndex = 11;
            this.inicio.Text = "Inicio";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(325, 234);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.addL);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.tema);
            this.Controls.Add(this.paginas);
            this.Controls.Add(this.existencia);
            this.Controls.Add(this.nombreLibro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "agregar";
            this.Text = "Agregar Libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombreLibro;
        private System.Windows.Forms.TextBox existencia;
        private System.Windows.Forms.TextBox paginas;
        private System.Windows.Forms.TextBox tema;
        private System.Windows.Forms.TextBox autor;
        private System.Windows.Forms.Button addL;
        private System.Windows.Forms.Button inicio;
    }
}