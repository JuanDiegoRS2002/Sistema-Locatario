namespace Sistema_Locatario
{
    partial class Trabajador
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.LBCategorias = new System.Windows.Forms.Label();
            this.DTTJ = new System.Windows.Forms.DataGridView();
            this.IdTrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antecedentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAntecedentes = new System.Windows.Forms.MaskedTextBox();
            this.txtEdad = new System.Windows.Forms.MaskedTextBox();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdUltimo = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.cmdPrimero = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTTJ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Profesion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre:";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(91, 171);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(100, 20);
            this.txtProfesion.TabIndex = 42;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(91, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 40;
            // 
            // LBCategorias
            // 
            this.LBCategorias.AutoSize = true;
            this.LBCategorias.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCategorias.Location = new System.Drawing.Point(15, 9);
            this.LBCategorias.Name = "LBCategorias";
            this.LBCategorias.Size = new System.Drawing.Size(200, 47);
            this.LBCategorias.TabIndex = 39;
            this.LBCategorias.Text = "Trabajadores";
            // 
            // DTTJ
            // 
            this.DTTJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTTJ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTrabajador,
            this.Nombre,
            this.Telefono,
            this.Profesion,
            this.Edad,
            this.Antecedentes});
            this.DTTJ.Enabled = false;
            this.DTTJ.Location = new System.Drawing.Point(221, 26);
            this.DTTJ.Name = "DTTJ";
            this.DTTJ.Size = new System.Drawing.Size(638, 150);
            this.DTTJ.TabIndex = 48;
            // 
            // IdTrabajador
            // 
            this.IdTrabajador.HeaderText = "IdTrabajador";
            this.IdTrabajador.Name = "IdTrabajador";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Profesion
            // 
            this.Profesion.HeaderText = "Profesion";
            this.Profesion.Name = "Profesion";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Antecedentes
            // 
            this.Antecedentes.HeaderText = "Antecedentes";
            this.Antecedentes.Name = "Antecedentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Antecedentes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Edad:";
            // 
            // txtAntecedentes
            // 
            this.txtAntecedentes.Location = new System.Drawing.Point(91, 212);
            this.txtAntecedentes.Name = "txtAntecedentes";
            this.txtAntecedentes.Size = new System.Drawing.Size(100, 20);
            this.txtAntecedentes.TabIndex = 50;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(92, 135);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 53;
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Location = new System.Drawing.Point(503, 212);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(75, 23);
            this.cmdAnterior.TabIndex = 61;
            this.cmdAnterior.Text = "Anterior";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdUltimo
            // 
            this.cmdUltimo.Location = new System.Drawing.Point(584, 182);
            this.cmdUltimo.Name = "cmdUltimo";
            this.cmdUltimo.Size = new System.Drawing.Size(75, 23);
            this.cmdUltimo.TabIndex = 60;
            this.cmdUltimo.Text = "Ultimo";
            this.cmdUltimo.UseVisualStyleBackColor = true;
            this.cmdUltimo.Click += new System.EventHandler(this.cmdUltimo_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Location = new System.Drawing.Point(503, 182);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(75, 23);
            this.cmdSiguiente.TabIndex = 59;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdPrimero
            // 
            this.cmdPrimero.Location = new System.Drawing.Point(419, 182);
            this.cmdPrimero.Name = "cmdPrimero";
            this.cmdPrimero.Size = new System.Drawing.Size(75, 23);
            this.cmdPrimero.TabIndex = 58;
            this.cmdPrimero.Text = "Primero";
            this.cmdPrimero.UseVisualStyleBackColor = true;
            this.cmdPrimero.Click += new System.EventHandler(this.cmdPrimero_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(777, 281);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 57;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(177, 238);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.TabIndex = 56;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(91, 238);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(75, 23);
            this.cmdGrabar.TabIndex = 55;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(7, 238);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
            this.cmdNuevo.TabIndex = 54;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(92, 93);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 62;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(91, 267);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 70;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // Trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 316);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.cmdUltimo);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdPrimero);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAntecedentes);
            this.Controls.Add(this.DTTJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LBCategorias);
            this.Name = "Trabajador";
            this.Text = "Trabajador";
            this.Load += new System.EventHandler(this.Trabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTTJ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtProfesion;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label LBCategorias;
        private System.Windows.Forms.DataGridView DTTJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtAntecedentes;
        private System.Windows.Forms.MaskedTextBox txtEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antecedentes;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.Button cmdUltimo;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Button cmdPrimero;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Button cmdConsultar;
    }
}