namespace Sistema_Locatario
{
    partial class Consultar_PedidosIndividual
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
            this.GBCliente = new System.Windows.Forms.GroupBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DTGFrutas = new System.Windows.Forms.DataGridView();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrutaOVerdura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFrutas)).BeginInit();
            this.SuspendLayout();
            // 
            // GBCliente
            // 
            this.GBCliente.Controls.Add(this.cmdBuscar);
            this.GBCliente.Controls.Add(this.txtIdCliente);
            this.GBCliente.Controls.Add(this.label19);
            this.GBCliente.Controls.Add(this.txtTelefono);
            this.GBCliente.Controls.Add(this.label5);
            this.GBCliente.Controls.Add(this.txtNombre);
            this.GBCliente.Controls.Add(this.label4);
            this.GBCliente.Controls.Add(this.label3);
            this.GBCliente.Controls.Add(this.CboCliente);
            this.GBCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCliente.Location = new System.Drawing.Point(5, 67);
            this.GBCliente.Name = "GBCliente";
            this.GBCliente.Size = new System.Drawing.Size(575, 153);
            this.GBCliente.TabIndex = 44;
            this.GBCliente.TabStop = false;
            this.GBCliente.Text = "Cliente";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(222, 118);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(112, 29);
            this.cmdBuscar.TabIndex = 49;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(385, 28);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(154, 29);
            this.txtIdCliente.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(294, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 28);
            this.label19.TabIndex = 26;
            this.label19.Text = "Numero#";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(408, 80);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(145, 29);
            this.txtTelefono.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(95, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 29);
            this.txtNombre.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente";
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(121, 24);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(163, 32);
            this.CboCliente.TabIndex = 12;
            this.CboCliente.SelectedIndexChanged += new System.EventHandler(this.CboCliente_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(206, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 47);
            this.label10.TabIndex = 78;
            this.label10.Text = "Consultar";
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
            this.DTGFrutas.Location = new System.Drawing.Point(5, 224);
            this.DTGFrutas.Name = "DTGFrutas";
            this.DTGFrutas.Size = new System.Drawing.Size(757, 120);
            this.DTGFrutas.TabIndex = 79;
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
            // Consultar_PedidosIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 358);
            this.Controls.Add(this.DTGFrutas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GBCliente);
            this.Name = "Consultar_PedidosIndividual";
            this.Text = "Pedidos X Cliente";
            this.Load += new System.EventHandler(this.Consultar_PedidosIndividual_Load);
            this.GBCliente.ResumeLayout(false);
            this.GBCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFrutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCliente;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.MaskedTextBox txtIdCliente;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.Label label10;
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