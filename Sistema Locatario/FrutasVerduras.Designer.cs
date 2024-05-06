namespace Sistema_Locatario
{
    partial class FrutasVerduras
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
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.txtExistenciasKG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioMenudeo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioMayoreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.DTGF = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.LBCategorias = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdUltimo = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.cmdPrimero = new System.Windows.Forms.Button();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IdFrutaVerdura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMayoreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMenudeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciasKG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagenUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGF)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(166, 250);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.TabIndex = 43;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(795, 313);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 42;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // txtExistenciasKG
            // 
            this.txtExistenciasKG.Location = new System.Drawing.Point(90, 181);
            this.txtExistenciasKG.Name = "txtExistenciasKG";
            this.txtExistenciasKG.Size = new System.Drawing.Size(100, 20);
            this.txtExistenciasKG.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Existencias KG";
            // 
            // txtPrecioMenudeo
            // 
            this.txtPrecioMenudeo.Location = new System.Drawing.Point(90, 155);
            this.txtPrecioMenudeo.Name = "txtPrecioMenudeo";
            this.txtPrecioMenudeo.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioMenudeo.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Precio Menudeo";
            // 
            // txtPrecioMayoreo
            // 
            this.txtPrecioMayoreo.Location = new System.Drawing.Point(90, 129);
            this.txtPrecioMayoreo.Name = "txtPrecioMayoreo";
            this.txtPrecioMayoreo.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioMayoreo.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Precio Mayoreo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Categoria:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 33;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(85, 250);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(75, 23);
            this.cmdGrabar.TabIndex = 31;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(1, 250);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
            this.cmdNuevo.TabIndex = 30;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // DTGF
            // 
            this.DTGF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFrutaVerdura,
            this.Concepto,
            this.Nombre,
            this.PrecioMayoreo,
            this.PrecioMenudeo,
            this.ExistenciasKG,
            this.ImagenUrl});
            this.DTGF.Location = new System.Drawing.Point(217, 59);
            this.DTGF.Name = "DTGF";
            this.DTGF.Size = new System.Drawing.Size(730, 150);
            this.DTGF.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre:";
            // 
            // LBCategorias
            // 
            this.LBCategorias.AutoSize = true;
            this.LBCategorias.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCategorias.Location = new System.Drawing.Point(336, 9);
            this.LBCategorias.Name = "LBCategorias";
            this.LBCategorias.Size = new System.Drawing.Size(245, 47);
            this.LBCategorias.TabIndex = 26;
            this.LBCategorias.Text = "Frutas/Verduras";
            // 
            // CboCategoria
            // 
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(69, 50);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(121, 21);
            this.CboCategoria.TabIndex = 34;
            this.CboCategoria.SelectedIndexChanged += new System.EventHandler(this.CboCategoria_SelectedIndexChanged);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Location = new System.Drawing.Point(506, 245);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(75, 23);
            this.cmdAnterior.TabIndex = 65;
            this.cmdAnterior.Text = "Anterior";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdUltimo
            // 
            this.cmdUltimo.Location = new System.Drawing.Point(587, 215);
            this.cmdUltimo.Name = "cmdUltimo";
            this.cmdUltimo.Size = new System.Drawing.Size(75, 23);
            this.cmdUltimo.TabIndex = 64;
            this.cmdUltimo.Text = "Ultimo";
            this.cmdUltimo.UseVisualStyleBackColor = true;
            this.cmdUltimo.Click += new System.EventHandler(this.cmdUltimo_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Location = new System.Drawing.Point(506, 215);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(75, 23);
            this.cmdSiguiente.TabIndex = 63;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdPrimero
            // 
            this.cmdPrimero.Location = new System.Drawing.Point(422, 215);
            this.cmdPrimero.Name = "cmdPrimero";
            this.cmdPrimero.Size = new System.Drawing.Size(75, 23);
            this.cmdPrimero.TabIndex = 62;
            this.cmdPrimero.Text = "Primero";
            this.cmdPrimero.UseVisualStyleBackColor = true;
            this.cmdPrimero.Click += new System.EventHandler(this.cmdPrimero_Click);
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Enabled = false;
            this.txtIdCategoria.Location = new System.Drawing.Point(90, 77);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtIdCategoria.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Numero:";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(85, 291);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 68;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(90, 207);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(100, 20);
            this.txtImagenUrl.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Imagen Url";
            // 
            // IdFrutaVerdura
            // 
            this.IdFrutaVerdura.HeaderText = "IdFrutaVerdura";
            this.IdFrutaVerdura.Name = "IdFrutaVerdura";
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // PrecioMayoreo
            // 
            this.PrecioMayoreo.HeaderText = "PrecioMayoreo";
            this.PrecioMayoreo.Name = "PrecioMayoreo";
            // 
            // PrecioMenudeo
            // 
            this.PrecioMenudeo.HeaderText = "PrecioMenudeo";
            this.PrecioMenudeo.Name = "PrecioMenudeo";
            // 
            // ExistenciasKG
            // 
            this.ExistenciasKG.HeaderText = "ExistenciasKG";
            this.ExistenciasKG.Name = "ExistenciasKG";
            // 
            // ImagenUrl
            // 
            this.ImagenUrl.HeaderText = "Imagen Url";
            this.ImagenUrl.Name = "ImagenUrl";
            // 
            // FrutasVerduras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 363);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.cmdUltimo);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdPrimero);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.txtExistenciasKG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecioMenudeo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioMayoreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.DTGF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBCategorias);
            this.Name = "FrutasVerduras";
            this.Text = "FrutasVerduras";
            this.Load += new System.EventHandler(this.FrutasVerduras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.TextBox txtExistenciasKG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioMenudeo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioMayoreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.DataGridView DTGF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBCategorias;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.Button cmdUltimo;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Button cmdPrimero;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFrutaVerdura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMayoreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMenudeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciasKG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagenUrl;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Label label7;
    }
}