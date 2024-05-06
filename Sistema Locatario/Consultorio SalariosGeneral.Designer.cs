namespace Sistema_Locatario
{
    partial class Consultorio_SalariosGeneral
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
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.DTFD = new System.Windows.Forms.DateTimePicker();
            this.DTFA = new System.Windows.Forms.DateTimePicker();
            this.DTGC = new System.Windows.Forms.DataGridView();
            this.Trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoXComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTGC)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(307, 98);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(112, 23);
            this.cmdBuscar.TabIndex = 62;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // DTFD
            // 
            this.DTFD.Location = new System.Drawing.Point(376, 59);
            this.DTFD.Name = "DTFD";
            this.DTFD.Size = new System.Drawing.Size(200, 20);
            this.DTFD.TabIndex = 61;
            // 
            // DTFA
            // 
            this.DTFA.Location = new System.Drawing.Point(142, 59);
            this.DTFA.Name = "DTFA";
            this.DTFA.Size = new System.Drawing.Size(200, 20);
            this.DTFA.TabIndex = 60;
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
            this.SalarioTotal});
            this.DTGC.Location = new System.Drawing.Point(12, 126);
            this.DTGC.Name = "DTGC";
            this.DTGC.Size = new System.Drawing.Size(671, 176);
            this.DTGC.TabIndex = 63;
            // 
            // Trabajador
            // 
            this.Trabajador.HeaderText = "Trabajador";
            this.Trabajador.Name = "Trabajador";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
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
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(571, 323);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(112, 23);
            this.cmdSalir.TabIndex = 64;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(299, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 47);
            this.label10.TabIndex = 65;
            this.label10.Text = "Consultar";
            // 
            // Consultorio_SalariosGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 358);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.DTGC);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.DTFD);
            this.Controls.Add(this.DTFA);
            this.Name = "Consultorio_SalariosGeneral";
            this.Text = "Consultorio_SalariosGeneral";
            this.Load += new System.EventHandler(this.Consultorio_SalariosGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DateTimePicker DTFD;
        private System.Windows.Forms.DateTimePicker DTFA;
        private System.Windows.Forms.DataGridView DTGC;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoXComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioTotal;
    }
}