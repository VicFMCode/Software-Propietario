namespace DAS_Def_1
{
    partial class MenuBiblioteca
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
            this.RegistroLibro = new System.Windows.Forms.Button();
            this.Bienvenida = new System.Windows.Forms.Label();
            this.ConsultaLibro = new System.Windows.Forms.Button();
            this.ActualizaLibro = new System.Windows.Forms.Button();
            this.EliminaLibro = new System.Windows.Forms.Button();
            this.GestionLibro = new System.Windows.Forms.GroupBox();
            this.GestionUsuario = new System.Windows.Forms.GroupBox();
            this.RegistroUsuario = new System.Windows.Forms.Button();
            this.RemoverUsuario = new System.Windows.Forms.Button();
            this.OtraGes = new System.Windows.Forms.GroupBox();
            this.Grafic = new System.Windows.Forms.Button();
            this.HistPrest = new System.Windows.Forms.Button();
            this.PrestDevol = new System.Windows.Forms.Button();
            this.uC_AgregarLibro1 = new DAS_Def_1.UC_AgregarLibro();
            this.GestionLibro.SuspendLayout();
            this.GestionUsuario.SuspendLayout();
            this.OtraGes.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistroLibro
            // 
            this.RegistroLibro.Location = new System.Drawing.Point(34, 19);
            this.RegistroLibro.Name = "RegistroLibro";
            this.RegistroLibro.Size = new System.Drawing.Size(174, 26);
            this.RegistroLibro.TabIndex = 0;
            this.RegistroLibro.Text = "Registrar nuevo libro";
            this.RegistroLibro.UseVisualStyleBackColor = true;
            this.RegistroLibro.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenida.Location = new System.Drawing.Point(27, 33);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(352, 25);
            this.Bienvenida.TabIndex = 1;
            this.Bienvenida.Text = "Bienvenido, seleccione una opcion:";
            this.Bienvenida.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConsultaLibro
            // 
            this.ConsultaLibro.Location = new System.Drawing.Point(33, 51);
            this.ConsultaLibro.Name = "ConsultaLibro";
            this.ConsultaLibro.Size = new System.Drawing.Size(174, 26);
            this.ConsultaLibro.TabIndex = 4;
            this.ConsultaLibro.Text = "Consultar libros";
            this.ConsultaLibro.UseVisualStyleBackColor = true;
            // 
            // ActualizaLibro
            // 
            this.ActualizaLibro.Location = new System.Drawing.Point(34, 83);
            this.ActualizaLibro.Name = "ActualizaLibro";
            this.ActualizaLibro.Size = new System.Drawing.Size(174, 26);
            this.ActualizaLibro.TabIndex = 5;
            this.ActualizaLibro.Text = "Actualizacion de libros";
            this.ActualizaLibro.UseVisualStyleBackColor = true;
            // 
            // EliminaLibro
            // 
            this.EliminaLibro.Location = new System.Drawing.Point(34, 115);
            this.EliminaLibro.Name = "EliminaLibro";
            this.EliminaLibro.Size = new System.Drawing.Size(174, 26);
            this.EliminaLibro.TabIndex = 6;
            this.EliminaLibro.Text = "Eliminar libro";
            this.EliminaLibro.UseVisualStyleBackColor = true;
            // 
            // GestionLibro
            // 
            this.GestionLibro.Controls.Add(this.EliminaLibro);
            this.GestionLibro.Controls.Add(this.ActualizaLibro);
            this.GestionLibro.Controls.Add(this.ConsultaLibro);
            this.GestionLibro.Controls.Add(this.RegistroLibro);
            this.GestionLibro.Location = new System.Drawing.Point(32, 76);
            this.GestionLibro.Name = "GestionLibro";
            this.GestionLibro.Size = new System.Drawing.Size(248, 154);
            this.GestionLibro.TabIndex = 7;
            this.GestionLibro.TabStop = false;
            this.GestionLibro.Text = "Gestion de Libros";
            this.GestionLibro.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GestionUsuario
            // 
            this.GestionUsuario.Controls.Add(this.RemoverUsuario);
            this.GestionUsuario.Controls.Add(this.RegistroUsuario);
            this.GestionUsuario.Location = new System.Drawing.Point(32, 226);
            this.GestionUsuario.Name = "GestionUsuario";
            this.GestionUsuario.Size = new System.Drawing.Size(248, 91);
            this.GestionUsuario.TabIndex = 8;
            this.GestionUsuario.TabStop = false;
            this.GestionUsuario.Text = "Gestion de Usuario";
            // 
            // RegistroUsuario
            // 
            this.RegistroUsuario.Location = new System.Drawing.Point(34, 19);
            this.RegistroUsuario.Name = "RegistroUsuario";
            this.RegistroUsuario.Size = new System.Drawing.Size(174, 26);
            this.RegistroUsuario.TabIndex = 0;
            this.RegistroUsuario.Text = "Registrar nuevo usuario";
            this.RegistroUsuario.UseVisualStyleBackColor = true;
            // 
            // RemoverUsuario
            // 
            this.RemoverUsuario.Location = new System.Drawing.Point(34, 51);
            this.RemoverUsuario.Name = "RemoverUsuario";
            this.RemoverUsuario.Size = new System.Drawing.Size(174, 26);
            this.RemoverUsuario.TabIndex = 4;
            this.RemoverUsuario.Text = "Eliminar usuario";
            this.RemoverUsuario.UseVisualStyleBackColor = true;
            // 
            // OtraGes
            // 
            this.OtraGes.Controls.Add(this.Grafic);
            this.OtraGes.Controls.Add(this.HistPrest);
            this.OtraGes.Controls.Add(this.PrestDevol);
            this.OtraGes.Location = new System.Drawing.Point(32, 313);
            this.OtraGes.Name = "OtraGes";
            this.OtraGes.Size = new System.Drawing.Size(248, 121);
            this.OtraGes.TabIndex = 9;
            this.OtraGes.TabStop = false;
            this.OtraGes.Text = "Otras Gestiones";
            // 
            // Grafic
            // 
            this.Grafic.Location = new System.Drawing.Point(34, 83);
            this.Grafic.Name = "Grafic";
            this.Grafic.Size = new System.Drawing.Size(174, 26);
            this.Grafic.TabIndex = 5;
            this.Grafic.Text = "Generacion de Graficos";
            this.Grafic.UseVisualStyleBackColor = true;
            // 
            // HistPrest
            // 
            this.HistPrest.Location = new System.Drawing.Point(33, 51);
            this.HistPrest.Name = "HistPrest";
            this.HistPrest.Size = new System.Drawing.Size(174, 26);
            this.HistPrest.TabIndex = 4;
            this.HistPrest.Text = "Historial de Prestamos";
            this.HistPrest.UseVisualStyleBackColor = true;
            // 
            // PrestDevol
            // 
            this.PrestDevol.Location = new System.Drawing.Point(34, 19);
            this.PrestDevol.Name = "PrestDevol";
            this.PrestDevol.Size = new System.Drawing.Size(174, 26);
            this.PrestDevol.TabIndex = 0;
            this.PrestDevol.Text = "Prestamos y Devoluciones";
            this.PrestDevol.UseVisualStyleBackColor = true;
            // 
            // uC_AgregarLibro1
            // 
            this.uC_AgregarLibro1.Location = new System.Drawing.Point(357, 95);
            this.uC_AgregarLibro1.Name = "uC_AgregarLibro1";
            this.uC_AgregarLibro1.Size = new System.Drawing.Size(364, 273);
            this.uC_AgregarLibro1.TabIndex = 10;
            // 
            // MenuBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uC_AgregarLibro1);
            this.Controls.Add(this.OtraGes);
            this.Controls.Add(this.GestionUsuario);
            this.Controls.Add(this.GestionLibro);
            this.Controls.Add(this.Bienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuBiblioteca";
            this.Text = "Biblioteca UDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GestionLibro.ResumeLayout(false);
            this.GestionUsuario.ResumeLayout(false);
            this.OtraGes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistroLibro;
        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.Button ConsultaLibro;
        private System.Windows.Forms.Button ActualizaLibro;
        private System.Windows.Forms.Button EliminaLibro;
        private System.Windows.Forms.GroupBox GestionLibro;
        private System.Windows.Forms.GroupBox GestionUsuario;
        private System.Windows.Forms.Button RegistroUsuario;
        private System.Windows.Forms.Button RemoverUsuario;
        private System.Windows.Forms.GroupBox OtraGes;
        private System.Windows.Forms.Button Grafic;
        private System.Windows.Forms.Button HistPrest;
        private System.Windows.Forms.Button PrestDevol;
        private UC_AgregarLibro uC_AgregarLibro1;
    }
}

