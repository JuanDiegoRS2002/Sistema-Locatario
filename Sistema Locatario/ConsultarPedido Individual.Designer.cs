namespace Sistema_Locatario
{
    partial class ConsultarPedido_Individual
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
            this.txtIdPedido = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.DTGFrutas = new System.Windows.Forms.DataGridView();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrutaOVerdura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFrutas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(277, 72);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(154, 20);
            this.txtIdPedido.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(131, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 28);
            this.label19.TabIndex = 28;
            this.label19.Text = "Numero Pedido#";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(269, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 47);
            this.label10.TabIndex = 79;
            this.label10.Text = "Consultar";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(277, 116);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(112, 29);
            this.cmdBuscar.TabIndex = 80;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // DTGFrutas
            // 
            this.DTGFrutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGFrutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Concepto,
            this.Cliente,
            this.FrutaOVerdura,
            this.Precio,
            this.Cantidad,
            this.Totala,
            this.Total});
            this.DTGFrutas.Location = new System.Drawing.Point(12, 169);
            this.DTGFrutas.Name = "DTGFrutas";
            this.DTGFrutas.Size = new System.Drawing.Size(749, 120);
            this.DTGFrutas.TabIndex = 81;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "IdPedido";
            this.Concepto.Name = "Concepto";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // FrutaOVerdura
            // 
            this.FrutaOVerdura.HeaderText = "FrutaOVerdura";
            this.FrutaOVerdura.Name = "FrutaOVerdura";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Totala
            // 
            this.Totala.HeaderText = "Importe";
            this.Totala.Name = "Totala";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // ConsultarPedido_Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 301);
            this.Controls.Add(this.DTGFrutas);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.label19);
            this.Name = "ConsultarPedido_Individual";
            this.Text = "Pedido Individual";
            this.Load += new System.EventHandler(this.ConsultarPedido_Individual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGFrutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtIdPedido;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridView DTGFrutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrutaOVerdura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}