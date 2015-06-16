namespace practica1
{
    partial class cliente
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.dpi1 = new System.Windows.Forms.TextBox();
            this.dir = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.addC = new System.Windows.Forms.Button();
            this.inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Carnet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre Completo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "DPI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Direccion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Telefono";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(139, 13);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(145, 20);
            this.id.TabIndex = 5;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(139, 43);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(145, 20);
            this.nombre.TabIndex = 6;
            // 
            // dpi1
            // 
            this.dpi1.Location = new System.Drawing.Point(139, 70);
            this.dpi1.Name = "dpi1";
            this.dpi1.Size = new System.Drawing.Size(145, 20);
            this.dpi1.TabIndex = 7;
            // 
            // dir
            // 
            this.dir.Location = new System.Drawing.Point(139, 100);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(145, 20);
            this.dir.TabIndex = 8;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(139, 134);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(145, 20);
            this.tel.TabIndex = 9;
            // 
            // addC
            // 
            this.addC.Location = new System.Drawing.Point(16, 185);
            this.addC.Name = "addC";
            this.addC.Size = new System.Drawing.Size(75, 23);
            this.addC.TabIndex = 10;
            this.addC.Text = "Agregar";
            this.addC.UseVisualStyleBackColor = true;
            this.addC.Click += new System.EventHandler(this.addC_Click);
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(208, 185);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(75, 23);
            this.inicio.TabIndex = 11;
            this.inicio.Text = "inicio";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // cliente
            // 
            this.ClientSize = new System.Drawing.Size(299, 229);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.addC);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.dpi1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "cliente";
            this.Text = "Agregar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox carnet;
        private System.Windows.Forms.TextBox NombreC;
        private System.Windows.Forms.TextBox dpi;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox dpi1;
        private System.Windows.Forms.TextBox dir;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Button addC;
        private System.Windows.Forms.Button inicio;
    }
}