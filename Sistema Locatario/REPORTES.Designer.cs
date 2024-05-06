namespace Sistema_Locatario
{
    partial class REPORTES
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdFrutasVerduras = new System.Windows.Forms.Button();
            this.comboBoxConcepto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboTrabajador = new System.Windows.Forms.ComboBox();
            this.cmdBuscarTrabajador = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cmdPedidoXCliente = new System.Windows.Forms.Button();
            this.DTFB = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.DTFA = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.cboTrabajadoresChoferes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboConcepto = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdCobroPedido = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.CboTrabajador2 = new System.Windows.Forms.ComboBox();
            this.cmdSalario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdFrutasVerdVendidas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdTotalPedidos = new System.Windows.Forms.Button();
            this.CboTrabajador1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cmdPedidoXClienteXEstado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Locatario.REPORTE FRUTASVERDYRAS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(319, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(682, 290);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORTES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdFrutasVerduras);
            this.groupBox1.Controls.Add(this.comboBoxConcepto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboTrabajador);
            this.groupBox1.Controls.Add(this.cmdBuscarTrabajador);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catalogos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Reporte Existencias FrutasVerduras + o -";
            // 
            // cmdFrutasVerduras
            // 
            this.cmdFrutasVerduras.Location = new System.Drawing.Point(546, 24);
            this.cmdFrutasVerduras.Name = "cmdFrutasVerduras";
            this.cmdFrutasVerduras.Size = new System.Drawing.Size(123, 36);
            this.cmdFrutasVerduras.TabIndex = 11;
            this.cmdFrutasVerduras.Text = "Buscar";
            this.cmdFrutasVerduras.UseVisualStyleBackColor = true;
            this.cmdFrutasVerduras.Click += new System.EventHandler(this.cmdFrutasVerduras_Click);
            // 
            // comboBoxConcepto
            // 
            this.comboBoxConcepto.FormattingEnabled = true;
            this.comboBoxConcepto.Location = new System.Drawing.Point(420, 28);
            this.comboBoxConcepto.Name = "comboBoxConcepto";
            this.comboBoxConcepto.Size = new System.Drawing.Size(121, 32);
            this.comboBoxConcepto.TabIndex = 10;
            this.comboBoxConcepto.SelectedIndexChanged += new System.EventHandler(this.comboBoxConcepto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reporte Trabajador x Profesion:";
            // 
            // CboTrabajador
            // 
            this.CboTrabajador.FormattingEnabled = true;
            this.CboTrabajador.Location = new System.Drawing.Point(326, 68);
            this.CboTrabajador.Name = "CboTrabajador";
            this.CboTrabajador.Size = new System.Drawing.Size(121, 32);
            this.CboTrabajador.TabIndex = 9;
            this.CboTrabajador.SelectedIndexChanged += new System.EventHandler(this.CboTrabajador_SelectedIndexChanged);
            // 
            // cmdBuscarTrabajador
            // 
            this.cmdBuscarTrabajador.Location = new System.Drawing.Point(453, 65);
            this.cmdBuscarTrabajador.Name = "cmdBuscarTrabajador";
            this.cmdBuscarTrabajador.Size = new System.Drawing.Size(123, 36);
            this.cmdBuscarTrabajador.TabIndex = 8;
            this.cmdBuscarTrabajador.Text = "Buscar";
            this.cmdBuscarTrabajador.UseVisualStyleBackColor = true;
            this.cmdBuscarTrabajador.Click += new System.EventHandler(this.cmdBuscarTrabajador_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(1217, 114);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(123, 36);
            this.cmdSalir.TabIndex = 8;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.cmdPedidoXCliente);
            this.groupBox2.Controls.Add(this.cmdSalir);
            this.groupBox2.Controls.Add(this.DTFB);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.DTFA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.cboTrabajadoresChoferes);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboConcepto);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmdCobroPedido);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CboTrabajador2);
            this.groupBox2.Controls.Add(this.cmdSalario);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmdFrutasVerdVendidas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmdTotalPedidos);
            this.groupBox2.Controls.Add(this.CboTrabajador1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboCliente);
            this.groupBox2.Controls.Add(this.cmdPedidoXClienteXEstado);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 462);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1346, 238);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimientos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(261, 108);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(121, 29);
            this.txtEstado.TabIndex = 36;
            // 
            // cmdPedidoXCliente
            // 
            this.cmdPedidoXCliente.Location = new System.Drawing.Point(388, 158);
            this.cmdPedidoXCliente.Name = "cmdPedidoXCliente";
            this.cmdPedidoXCliente.Size = new System.Drawing.Size(123, 36);
            this.cmdPedidoXCliente.TabIndex = 34;
            this.cmdPedidoXCliente.Text = "Buscar";
            this.cmdPedidoXCliente.UseVisualStyleBackColor = true;
            this.cmdPedidoXCliente.Click += new System.EventHandler(this.cmdPedidoXCliente_Click);
            // 
            // DTFB
            // 
            this.DTFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFB.Location = new System.Drawing.Point(330, 29);
            this.DTFB.Name = "DTFB";
            this.DTFB.Size = new System.Drawing.Size(281, 26);
            this.DTFB.TabIndex = 33;
            this.DTFB.Value = new System.DateTime(2024, 4, 26, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(303, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 24);
            this.label12.TabIndex = 32;
            this.label12.Text = "a";
            // 
            // DTFA
            // 
            this.DTFA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFA.Location = new System.Drawing.Point(16, 28);
            this.DTFA.Name = "DTFA";
            this.DTFA.Size = new System.Drawing.Size(281, 26);
            this.DTFA.TabIndex = 31;
            this.DTFA.Value = new System.DateTime(2024, 4, 26, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Viajes X Trabajador";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1004, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 36);
            this.button5.TabIndex = 29;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cboTrabajadoresChoferes
            // 
            this.cboTrabajadoresChoferes.FormattingEnabled = true;
            this.cboTrabajadoresChoferes.Location = new System.Drawing.Point(877, 111);
            this.cboTrabajadoresChoferes.Name = "cboTrabajadoresChoferes";
            this.cboTrabajadoresChoferes.Size = new System.Drawing.Size(121, 32);
            this.cboTrabajadoresChoferes.TabIndex = 28;
            this.cboTrabajadoresChoferes.SelectedIndexChanged += new System.EventHandler(this.cboTrabajadoresChoferes_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(676, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Viajes X Frutas/Verduras";
            // 
            // cboConcepto
            // 
            this.cboConcepto.FormattingEnabled = true;
            this.cboConcepto.Location = new System.Drawing.Point(925, 151);
            this.cboConcepto.Name = "cboConcepto";
            this.cboConcepto.Size = new System.Drawing.Size(121, 32);
            this.cboConcepto.TabIndex = 27;
            this.cboConcepto.SelectedIndexChanged += new System.EventHandler(this.cboConcepto_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1052, 149);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 36);
            this.button6.TabIndex = 26;
            this.button6.Text = "Buscar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(676, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "CobroPedido X Periodo";
            // 
            // cmdCobroPedido
            // 
            this.cmdCobroPedido.Location = new System.Drawing.Point(915, 18);
            this.cmdCobroPedido.Name = "cmdCobroPedido";
            this.cmdCobroPedido.Size = new System.Drawing.Size(123, 36);
            this.cmdCobroPedido.TabIndex = 23;
            this.cmdCobroPedido.Text = "Buscar";
            this.cmdCobroPedido.UseVisualStyleBackColor = true;
            this.cmdCobroPedido.Click += new System.EventHandler(this.cmdCobroPedido_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(676, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(302, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "Salario X Trabajador X Periodo";
            // 
            // CboTrabajador2
            // 
            this.CboTrabajador2.FormattingEnabled = true;
            this.CboTrabajador2.Location = new System.Drawing.Point(984, 64);
            this.CboTrabajador2.Name = "CboTrabajador2";
            this.CboTrabajador2.Size = new System.Drawing.Size(121, 32);
            this.CboTrabajador2.TabIndex = 21;
            this.CboTrabajador2.SelectedIndexChanged += new System.EventHandler(this.CboTrabajador2_SelectedIndexChanged);
            // 
            // cmdSalario
            // 
            this.cmdSalario.Location = new System.Drawing.Point(1111, 58);
            this.cmdSalario.Name = "cmdSalario";
            this.cmdSalario.Size = new System.Drawing.Size(123, 36);
            this.cmdSalario.TabIndex = 20;
            this.cmdSalario.Text = "Buscar";
            this.cmdSalario.UseVisualStyleBackColor = true;
            this.cmdSalario.Click += new System.EventHandler(this.cmdSalario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pedido X Cliente ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Frutas/Verduras + Vendida X Periodo";
            // 
            // cmdFrutasVerdVendidas
            // 
            this.cmdFrutasVerdVendidas.Location = new System.Drawing.Point(388, 200);
            this.cmdFrutasVerdVendidas.Name = "cmdFrutasVerdVendidas";
            this.cmdFrutasVerdVendidas.Size = new System.Drawing.Size(123, 36);
            this.cmdFrutasVerdVendidas.TabIndex = 14;
            this.cmdFrutasVerdVendidas.Text = "Buscar";
            this.cmdFrutasVerdVendidas.UseVisualStyleBackColor = true;
            this.cmdFrutasVerdVendidas.Click += new System.EventHandler(this.cmdFrutasVerdVendidas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(391, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total de Pedidos X Trabajador y Periodo";
            // 
            // cmdTotalPedidos
            // 
            this.cmdTotalPedidos.Location = new System.Drawing.Point(536, 62);
            this.cmdTotalPedidos.Name = "cmdTotalPedidos";
            this.cmdTotalPedidos.Size = new System.Drawing.Size(123, 36);
            this.cmdTotalPedidos.TabIndex = 11;
            this.cmdTotalPedidos.Text = "Buscar";
            this.cmdTotalPedidos.UseVisualStyleBackColor = true;
            this.cmdTotalPedidos.Click += new System.EventHandler(this.cmdTotalPedidos_Click);
            // 
            // CboTrabajador1
            // 
            this.CboTrabajador1.FormattingEnabled = true;
            this.CboTrabajador1.Location = new System.Drawing.Point(409, 67);
            this.CboTrabajador1.Name = "CboTrabajador1";
            this.CboTrabajador1.Size = new System.Drawing.Size(121, 32);
            this.CboTrabajador1.TabIndex = 10;
            this.CboTrabajador1.SelectedIndexChanged += new System.EventHandler(this.CboTrabajador1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pedido X Cliente X Estado";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(261, 153);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 32);
            this.cboCliente.TabIndex = 9;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // cmdPedidoXClienteXEstado
            // 
            this.cmdPedidoXClienteXEstado.Location = new System.Drawing.Point(388, 108);
            this.cmdPedidoXClienteXEstado.Name = "cmdPedidoXClienteXEstado";
            this.cmdPedidoXClienteXEstado.Size = new System.Drawing.Size(123, 36);
            this.cmdPedidoXClienteXEstado.TabIndex = 8;
            this.cmdPedidoXClienteXEstado.Text = "Buscar";
            this.cmdPedidoXClienteXEstado.UseVisualStyleBackColor = true;
            this.cmdPedidoXClienteXEstado.Click += new System.EventHandler(this.cmdPedidoXClienteXEstado_Click);
            // 
            // REPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "REPORTES";
            this.Text = "REPORTES";
            this.Load += new System.EventHandler(this.REPORTES_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboTrabajador;
        private System.Windows.Forms.Button cmdBuscarTrabajador;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.ComboBox comboBoxConcepto;
        private System.Windows.Forms.Button cmdFrutasVerduras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdFrutasVerdVendidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdTotalPedidos;
        private System.Windows.Forms.ComboBox CboTrabajador1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Button cmdPedidoXClienteXEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cboTrabajadoresChoferes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboConcepto;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdCobroPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboTrabajador2;
        private System.Windows.Forms.Button cmdSalario;
        private System.Windows.Forms.DateTimePicker DTFB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DTFA;
        private System.Windows.Forms.Button cmdPedidoXCliente;
        private System.Windows.Forms.TextBox txtEstado;
    }
}