namespace Sistema_Locatario
{
    partial class SaldosTrabajadores
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
            this.DTGTrabajador = new System.Windows.Forms.DataGridView();
            this.GBTrabajador = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreT = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboTrabajador = new System.Windows.Forms.ComboBox();
            this.txtIdSalario = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DTF = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.LBCategorias = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPorcentajeComision = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSueldoBase = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalComision = new System.Windows.Forms.MaskedTextBox();
            this.txtPedidosRealizados = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdInsertar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.DTVBuscar = new System.Windows.Forms.DataGridView();
            this.Trabajadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTFA = new System.Windows.Forms.DateTimePicker();
            this.DTFD = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.Trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoXComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGTrabajador)).BeginInit();
            this.GBTrabajador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTVBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGTrabajador
            // 
            this.DTGTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGTrabajador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Trabajador,
            this.SalarioBase,
            this.Comision,
            this.PedidoXComision,
            this.SalarioTotal});
            this.DTGTrabajador.Location = new System.Drawing.Point(478, 354);
            this.DTGTrabajador.Name = "DTGTrabajador";
            this.DTGTrabajador.Size = new System.Drawing.Size(546, 176);
            this.DTGTrabajador.TabIndex = 0;
            // 
            // GBTrabajador
            // 
            this.GBTrabajador.Controls.Add(this.txtNumero);
            this.GBTrabajador.Controls.Add(this.label9);
            this.GBTrabajador.Controls.Add(this.txtProfesion);
            this.GBTrabajador.Controls.Add(this.label7);
            this.GBTrabajador.Controls.Add(this.txtNombreT);
            this.GBTrabajador.Controls.Add(this.label8);
            this.GBTrabajador.Controls.Add(this.label6);
            this.GBTrabajador.Controls.Add(this.CboTrabajador);
            this.GBTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTrabajador.Location = new System.Drawing.Point(452, 110);
            this.GBTrabajador.Name = "GBTrabajador";
            this.GBTrabajador.Size = new System.Drawing.Size(711, 108);
            this.GBTrabajador.TabIndex = 44;
            this.GBTrabajador.TabStop = false;
            this.GBTrabajador.Text = "Trabajador";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(495, 28);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(154, 29);
            this.txtNumero.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(413, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 28);
            this.label9.TabIndex = 24;
            this.label9.Text = "Numero#";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Enabled = false;
            this.txtProfesion.Location = new System.Drawing.Point(447, 63);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(165, 29);
            this.txtProfesion.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "Profesion:";
            // 
            // txtNombreT
            // 
            this.txtNombreT.Enabled = false;
            this.txtNombreT.Location = new System.Drawing.Point(172, 64);
            this.txtNombreT.Name = "txtNombreT";
            this.txtNombreT.Size = new System.Drawing.Size(154, 29);
            this.txtNombreT.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Trabajador";
            // 
            // CboTrabajador
            // 
            this.CboTrabajador.FormattingEnabled = true;
            this.CboTrabajador.Location = new System.Drawing.Point(219, 25);
            this.CboTrabajador.Name = "CboTrabajador";
            this.CboTrabajador.Size = new System.Drawing.Size(163, 32);
            this.CboTrabajador.TabIndex = 18;
            this.CboTrabajador.SelectedIndexChanged += new System.EventHandler(this.CboTrabajador_SelectedIndexChanged);
            // 
            // txtIdSalario
            // 
            this.txtIdSalario.Enabled = false;
            this.txtIdSalario.Location = new System.Drawing.Point(947, 74);
            this.txtIdSalario.Name = "txtIdSalario";
            this.txtIdSalario.Size = new System.Drawing.Size(154, 20);
            this.txtIdSalario.TabIndex = 49;
            this.txtIdSalario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtIdSalario_MaskInputRejected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(865, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 28);
            this.label14.TabIndex = 48;
            this.label14.Text = "Numero#";
            // 
            // DTF
            // 
            this.DTF.Location = new System.Drawing.Point(527, 71);
            this.DTF.Name = "DTF";
            this.DTF.Size = new System.Drawing.Size(200, 20);
            this.DTF.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Fecha:";
            // 
            // LBCategorias
            // 
            this.LBCategorias.AutoSize = true;
            this.LBCategorias.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCategorias.Location = new System.Drawing.Point(625, 9);
            this.LBCategorias.Name = "LBCategorias";
            this.LBCategorias.Size = new System.Drawing.Size(288, 47);
            this.LBCategorias.TabIndex = 45;
            this.LBCategorias.Text = "Pagos Trabajadores";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPorcentajeComision);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtComision);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSueldoBase);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTotalComision);
            this.groupBox1.Controls.Add(this.txtPedidosRealizados);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(452, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 124);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salarios";
            // 
            // txtPorcentajeComision
            // 
            this.txtPorcentajeComision.Location = new System.Drawing.Point(462, 18);
            this.txtPorcentajeComision.Name = "txtPorcentajeComision";
            this.txtPorcentajeComision.Size = new System.Drawing.Size(165, 29);
            this.txtPorcentajeComision.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(353, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 28);
            this.label11.TabIndex = 30;
            this.label11.Text = "Comision%:";
            // 
            // txtComision
            // 
            this.txtComision.Enabled = false;
            this.txtComision.Location = new System.Drawing.Point(462, 54);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(165, 29);
            this.txtComision.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "Comision$:";
            // 
            // txtSueldoBase
            // 
            this.txtSueldoBase.Location = new System.Drawing.Point(181, 29);
            this.txtSueldoBase.Name = "txtSueldoBase";
            this.txtSueldoBase.Size = new System.Drawing.Size(154, 29);
            this.txtSueldoBase.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sueldo Base";
            // 
            // txtTotalComision
            // 
            this.txtTotalComision.Enabled = false;
            this.txtTotalComision.Location = new System.Drawing.Point(462, 88);
            this.txtTotalComision.Name = "txtTotalComision";
            this.txtTotalComision.Size = new System.Drawing.Size(165, 29);
            this.txtTotalComision.TabIndex = 23;
            // 
            // txtPedidosRealizados
            // 
            this.txtPedidosRealizados.Enabled = false;
            this.txtPedidosRealizados.Location = new System.Drawing.Point(181, 64);
            this.txtPedidosRealizados.Name = "txtPedidosRealizados";
            this.txtPedidosRealizados.Size = new System.Drawing.Size(154, 29);
            this.txtPedidosRealizados.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pedidos Realizados";
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(1051, 445);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(112, 23);
            this.cmdGrabar.TabIndex = 53;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdInsertar
            // 
            this.cmdInsertar.Location = new System.Drawing.Point(1051, 405);
            this.cmdInsertar.Name = "cmdInsertar";
            this.cmdInsertar.Size = new System.Drawing.Size(112, 23);
            this.cmdInsertar.TabIndex = 52;
            this.cmdInsertar.Text = "Inserta";
            this.cmdInsertar.UseVisualStyleBackColor = true;
            this.cmdInsertar.Click += new System.EventHandler(this.cmdInsertar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(1051, 366);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(112, 23);
            this.cmdNuevo.TabIndex = 51;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(1051, 486);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(112, 23);
            this.cmdSalir.TabIndex = 54;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // DTVBuscar
            // 
            this.DTVBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTVBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Trabajadores,
            this.Fecha,
            this.Total});
            this.DTVBuscar.Location = new System.Drawing.Point(64, 131);
            this.DTVBuscar.Name = "DTVBuscar";
            this.DTVBuscar.Size = new System.Drawing.Size(346, 356);
            this.DTVBuscar.TabIndex = 55;
            // 
            // Trabajadores
            // 
            this.Trabajadores.HeaderText = "Trabajadores";
            this.Trabajadores.Name = "Trabajadores";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // DTFA
            // 
            this.DTFA.Location = new System.Drawing.Point(12, 63);
            this.DTFA.Name = "DTFA";
            this.DTFA.Size = new System.Drawing.Size(200, 20);
            this.DTFA.TabIndex = 56;
            // 
            // DTFD
            // 
            this.DTFD.Location = new System.Drawing.Point(246, 63);
            this.DTFD.Name = "DTFD";
            this.DTFD.Size = new System.Drawing.Size(200, 20);
            this.DTFD.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(165, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 47);
            this.label10.TabIndex = 58;
            this.label10.Text = "Periodo";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(177, 102);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(112, 23);
            this.cmdBuscar.TabIndex = 59;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // Trabajador
            // 
            this.Trabajador.HeaderText = "Trabajador";
            this.Trabajador.Name = "Trabajador";
            // 
            // SalarioBase
            // 
            this.SalarioBase.HeaderText = "SalarioBase";
            this.SalarioBase.Name = "SalarioBase";
            // 
            // Comision
            // 
            this.Comision.HeaderText = "Comision%";
            this.Comision.Name = "Comision";
            // 
            // PedidoXComision
            // 
            this.PedidoXComision.HeaderText = "PedidoXComision";
            this.PedidoXComision.Name = "PedidoXComision";
            // 
            // SalarioTotal
            // 
            this.SalarioTotal.HeaderText = "SalarioTotal";
            this.SalarioTotal.Name = "SalarioTotal";
            // 
            // SaldosTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 528);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DTFD);
            this.Controls.Add(this.DTFA);
            this.Controls.Add(this.DTVBuscar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdInsertar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIdSalario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DTF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBCategorias);
            this.Controls.Add(this.GBTrabajador);
            this.Controls.Add(this.DTGTrabajador);
            this.Name = "SaldosTrabajadores";
            this.Text = "PagosTrabajadores";
            this.Load += new System.EventHandler(this.SaldosTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGTrabajador)).EndInit();
            this.GBTrabajador.ResumeLayout(false);
            this.GBTrabajador.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTVBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGTrabajador;
        private System.Windows.Forms.GroupBox GBTrabajador;
        private System.Windows.Forms.MaskedTextBox txtProfesion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtNombreT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboTrabajador;
        private System.Windows.Forms.MaskedTextBox txtIdSalario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DTF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBCategorias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtSueldoBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTotalComision;
        private System.Windows.Forms.MaskedTextBox txtPedidosRealizados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdInsertar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridView DTVBuscar;
        private System.Windows.Forms.MaskedTextBox txtComision;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DTFA;
        private System.Windows.Forms.DateTimePicker DTFD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabajadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.MaskedTextBox txtPorcentajeComision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoXComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioTotal;
    }
}