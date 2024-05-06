namespace Sistema_Locatario
{
    partial class ConsultarGeneral_CobroPedido
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
            this.label10 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.DTGC = new System.Windows.Forms.DataGridView();
            this.Trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoXComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.DTFA = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DTGC)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 47);
            this.label10.TabIndex = 77;
            this.label10.Text = "Consultar";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(648, 323);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(112, 23);
            this.cmdSalir.TabIndex = 76;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // DTGC
            // 
            this.DTGC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Trabajador,
            this.Fecha,
            this.SalarioBase,
            this.Comision,
            this.PedidoXComision,
            this.SalarioTotal,
            this.TotalDia});
            this.DTGC.Location = new System.Drawing.Point(8, 110);
            this.DTGC.Name = "DTGC";
            this.DTGC.Size = new System.Drawing.Size(752, 176);
            this.DTGC.TabIndex = 75;
            // 
            // Trabajador
            // 
            this.Trabajador.HeaderText = "Cliente";
            this.Trabajador.Name = "Trabajador";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "IdPedido";
            this.Fecha.Name = "Fecha";
            // 
            // SalarioBase
            // 
            this.SalarioBase.HeaderText = "Fecha Pedido";
            this.SalarioBase.Name = "SalarioBase";
            // 
            // Comision
            // 
            this.Comision.HeaderText = "FechaPago";
            this.Comision.Name = "Comision";
            // 
            // PedidoXComision
            // 
            this.PedidoXComision.HeaderText = "Total Pedido $";
            this.PedidoXComision.Name = "PedidoXComision";
            // 
            // SalarioTotal
            // 
            this.SalarioTotal.HeaderText = "Pagado $";
            this.SalarioTotal.Name = "SalarioTotal";
            // 
            // TotalDia
            // 
            this.TotalDia.HeaderText = "Total Dia $";
            this.TotalDia.Name = "TotalDia";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(347, 80);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(112, 23);
            this.cmdBuscar.TabIndex = 74;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // DTFA
            // 
            this.DTFA.Location = new System.Drawing.Point(297, 54);
            this.DTFA.Name = "DTFA";
            this.DTFA.Size = new System.Drawing.Size(200, 20);
            this.DTFA.TabIndex = 72;
            // 
            // ConsultarGeneral_CobroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 358);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.DTGC);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.DTFA);
            this.Name = "ConsultarGeneral_CobroPedido";
            this.Text = "ConsultarGeneral_CobroPedido";
            this.Load += new System.EventHandler(this.ConsultarGeneral_CobroPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridView DTGC;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DateTimePicker DTFA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoXComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDia;
    }
}