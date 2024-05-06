namespace Sistema_Locatario
{
    partial class Consultar_Pedido
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
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrutaOVerdura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.DTFBuscar = new System.Windows.Forms.DateTimePicker();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFrutas)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGFrutas
            // 
            this.DTGFrutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGFrutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Concepto,
            this.FrutaOVerdura,
            this.Precio,
            this.Cantidad,
            this.Importe,
            this.Total});
            this.DTGFrutas.Location = new System.Drawing.Point(12, 12);
            this.DTGFrutas.Name = "DTGFrutas";
            this.DTGFrutas.Size = new System.Drawing.Size(852, 120);
            this.DTGFrutas.TabIndex = 36;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Cliente";
            this.Concepto.Name = "Concepto";
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
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(671, 194);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(112, 23);
            this.cmdSalir.TabIndex = 37;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // DTFBuscar
            // 
            this.DTFBuscar.Location = new System.Drawing.Point(294, 148);
            this.DTFBuscar.Name = "DTFBuscar";
            this.DTFBuscar.Size = new System.Drawing.Size(200, 20);
            this.DTFBuscar.TabIndex = 38;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(327, 184);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(112, 23);
            this.cmdBuscar.TabIndex = 39;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Consultar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 229);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.DTFBuscar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.DTGFrutas);
            this.Name = "Consultar_Pedido";
            this.Text = "Consultar_Pedido";
            this.Load += new System.EventHandler(this.Consultar_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGFrutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGFrutas;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DateTimePicker DTFBuscar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrutaOVerdura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}