namespace Sistema_Locatario
{
    partial class Verificar_ViajeXProducto
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
            this.DTGFrutas = new System.Windows.Forms.DataGridView();
            this.IdFrutaVerdura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrutaVerdura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadNecesitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVerificada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBCategorias = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdTrabajador = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CboViajes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboTrabajador = new System.Windows.Forms.ComboBox();
            this.GBFrutasYVerduras = new System.Windows.Forms.GroupBox();
            this.txtExistencias = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.txtIdFrutaVerdu = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreFV = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CboFrutaVerdura = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFrutas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GBFrutasYVerduras.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTGFrutas
            // 
            this.DTGFrutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGFrutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFrutaVerdura,
            this.FrutaVerdura,
            this.CantidadNecesitada,
            this.CantidadVerificada});
            this.DTGFrutas.Enabled = false;
            this.DTGFrutas.Location = new System.Drawing.Point(153, 191);
            this.DTGFrutas.Name = "DTGFrutas";
            this.DTGFrutas.Size = new System.Drawing.Size(445, 112);
            this.DTGFrutas.TabIndex = 60;
            // 
            // IdFrutaVerdura
            // 
            this.IdFrutaVerdura.HeaderText = "IdFrutaVerdura";
            this.IdFrutaVerdura.Name = "IdFrutaVerdura";
            // 
            // FrutaVerdura
            // 
            this.FrutaVerdura.HeaderText = "FrutaVerdura";
            this.FrutaVerdura.Name = "FrutaVerdura";
            // 
            // CantidadNecesitada
            // 
            this.CantidadNecesitada.HeaderText = "Cantidad Necesitada";
            this.CantidadNecesitada.Name = "CantidadNecesitada";
            // 
            // CantidadVerificada
            // 
            this.CantidadVerificada.HeaderText = "CantidadVerificada";
            this.CantidadVerificada.Name = "CantidadVerificada";
            // 
            // LBCategorias
            // 
            this.LBCategorias.AutoSize = true;
            this.LBCategorias.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCategorias.Location = new System.Drawing.Point(236, 9);
            this.LBCategorias.Name = "LBCategorias";
            this.LBCategorias.Size = new System.Drawing.Size(259, 47);
            this.LBCategorias.TabIndex = 61;
            this.LBCategorias.Text = "Viajes Verificados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdTrabajador);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CboViajes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CboTrabajador);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 125);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viaje";
            // 
            // txtIdTrabajador
            // 
            this.txtIdTrabajador.Enabled = false;
            this.txtIdTrabajador.Location = new System.Drawing.Point(118, 66);
            this.txtIdTrabajador.Name = "txtIdTrabajador";
            this.txtIdTrabajador.Size = new System.Drawing.Size(163, 29);
            this.txtIdTrabajador.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 63;
            this.label2.Text = "Numero:";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(289, 81);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(112, 38);
            this.cmdBuscar.TabIndex = 34;
            this.cmdBuscar.Text = "Busca";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Numero Viaje";
            // 
            // CboViajes
            // 
            this.CboViajes.FormattingEnabled = true;
            this.CboViajes.Location = new System.Drawing.Point(478, 28);
            this.CboViajes.Name = "CboViajes";
            this.CboViajes.Size = new System.Drawing.Size(163, 32);
            this.CboViajes.TabIndex = 22;
            this.CboViajes.SelectedIndexChanged += new System.EventHandler(this.CboViajes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Trabajador";
            // 
            // CboTrabajador
            // 
            this.CboTrabajador.FormattingEnabled = true;
            this.CboTrabajador.Location = new System.Drawing.Point(118, 28);
            this.CboTrabajador.Name = "CboTrabajador";
            this.CboTrabajador.Size = new System.Drawing.Size(218, 32);
            this.CboTrabajador.TabIndex = 20;
            this.CboTrabajador.SelectedIndexChanged += new System.EventHandler(this.CboTrabajador_SelectedIndexChanged);
            // 
            // GBFrutasYVerduras
            // 
            this.GBFrutasYVerduras.Controls.Add(this.txtExistencias);
            this.GBFrutasYVerduras.Controls.Add(this.label3);
            this.GBFrutasYVerduras.Controls.Add(this.cmdSalir);
            this.GBFrutasYVerduras.Controls.Add(this.cmdVerificar);
            this.GBFrutasYVerduras.Controls.Add(this.txtIdFrutaVerdu);
            this.GBFrutasYVerduras.Controls.Add(this.label18);
            this.GBFrutasYVerduras.Controls.Add(this.txtCantidad);
            this.GBFrutasYVerduras.Controls.Add(this.label11);
            this.GBFrutasYVerduras.Controls.Add(this.txtNombreFV);
            this.GBFrutasYVerduras.Controls.Add(this.label12);
            this.GBFrutasYVerduras.Controls.Add(this.label10);
            this.GBFrutasYVerduras.Controls.Add(this.CboFrutaVerdura);
            this.GBFrutasYVerduras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFrutasYVerduras.Location = new System.Drawing.Point(21, 322);
            this.GBFrutasYVerduras.Name = "GBFrutasYVerduras";
            this.GBFrutasYVerduras.Size = new System.Drawing.Size(655, 202);
            this.GBFrutasYVerduras.TabIndex = 63;
            this.GBFrutasYVerduras.TabStop = false;
            this.GBFrutasYVerduras.Text = "Frutas Y Verduras";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Enabled = false;
            this.txtExistencias.Location = new System.Drawing.Point(103, 126);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(109, 29);
            this.txtExistencias.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 66;
            this.label3.Text = "Existencias";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(524, 158);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(112, 38);
            this.cmdSalir.TabIndex = 65;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Location = new System.Drawing.Point(524, 100);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(112, 38);
            this.cmdVerificar.TabIndex = 64;
            this.cmdVerificar.Text = "Verifica";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            this.cmdVerificar.Click += new System.EventHandler(this.cmdVerificar_Click);
            // 
            // txtIdFrutaVerdu
            // 
            this.txtIdFrutaVerdu.Enabled = false;
            this.txtIdFrutaVerdu.Location = new System.Drawing.Point(98, 82);
            this.txtIdFrutaVerdu.Name = "txtIdFrutaVerdu";
            this.txtIdFrutaVerdu.Size = new System.Drawing.Size(163, 29);
            this.txtIdFrutaVerdu.TabIndex = 62;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 28);
            this.label18.TabIndex = 61;
            this.label18.Text = "Numero:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(390, 127);
            this.txtCantidad.Mask = "99999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(118, 29);
            this.txtCantidad.TabIndex = 48;
            this.txtCantidad.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(218, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 28);
            this.label11.TabIndex = 47;
            this.label11.Text = "Cantidad Entregada:";
            // 
            // txtNombreFV
            // 
            this.txtNombreFV.Enabled = false;
            this.txtNombreFV.Location = new System.Drawing.Point(345, 82);
            this.txtNombreFV.Name = "txtNombreFV";
            this.txtNombreFV.Size = new System.Drawing.Size(163, 29);
            this.txtNombreFV.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(266, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 28);
            this.label12.TabIndex = 45;
            this.label12.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 28);
            this.label10.TabIndex = 44;
            this.label10.Text = "Frutas/Verduras:";
            // 
            // CboFrutaVerdura
            // 
            this.CboFrutaVerdura.FormattingEnabled = true;
            this.CboFrutaVerdura.Location = new System.Drawing.Point(205, 33);
            this.CboFrutaVerdura.Name = "CboFrutaVerdura";
            this.CboFrutaVerdura.Size = new System.Drawing.Size(163, 32);
            this.CboFrutaVerdura.TabIndex = 43;
            this.CboFrutaVerdura.SelectedIndexChanged += new System.EventHandler(this.CboFrutaVerdura_SelectedIndexChanged);
            // 
            // Verificar_ViajeXProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 549);
            this.Controls.Add(this.GBFrutasYVerduras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBCategorias);
            this.Controls.Add(this.DTGFrutas);
            this.Name = "Verificar_ViajeXProducto";
            this.Text = "Verificar_ViajeXProducto";
            this.Load += new System.EventHandler(this.Verificar_ViajeXProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGFrutas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBFrutasYVerduras.ResumeLayout(false);
            this.GBFrutasYVerduras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGFrutas;
        private System.Windows.Forms.Label LBCategorias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GBFrutasYVerduras;
        private System.Windows.Forms.MaskedTextBox txtIdFrutaVerdu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtNombreFV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CboFrutaVerdura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboTrabajador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboViajes;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdVerificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFrutaVerdura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrutaVerdura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadNecesitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVerificada;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.MaskedTextBox txtIdTrabajador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtExistencias;
        private System.Windows.Forms.Label label3;
    }
}