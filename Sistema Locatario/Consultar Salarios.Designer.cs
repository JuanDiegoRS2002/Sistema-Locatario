namespace Sistema_Locatario
{
    partial class Consultar_Salarios
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
            this.GBTrabajador = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreT = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboTrabajador = new System.Windows.Forms.ComboBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.DTGTrabajador = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoXComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.txtFechaFinal = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GBTrabajador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGTrabajador)).BeginInit();
            this.SuspendLayout();
            // 
            // GBTrabajador
            // 
            this.GBTrabajador.Controls.Add(this.txtFechaFinal);
            this.GBTrabajador.Controls.Add(this.label1);
            this.GBTrabajador.Controls.Add(this.txtFechaInicio);
            this.GBTrabajador.Controls.Add(this.label2);
            this.GBTrabajador.Controls.Add(this.txtNumero);
            this.GBTrabajador.Controls.Add(this.label9);
            this.GBTrabajador.Controls.Add(this.txtProfesion);
            this.GBTrabajador.Controls.Add(this.label7);
            this.GBTrabajador.Controls.Add(this.txtNombreT);
            this.GBTrabajador.Controls.Add(this.label8);
            this.GBTrabajador.Controls.Add(this.label6);
            this.GBTrabajador.Controls.Add(this.CboTrabajador);
            this.GBTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTrabajador.Location = new System.Drawing.Point(12, 22);
            this.GBTrabajador.Name = "GBTrabajador";
            this.GBTrabajador.Size = new System.Drawing.Size(711, 142);
            this.GBTrabajador.TabIndex = 45;
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
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(301, 170);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(112, 23);
            this.cmdBuscar.TabIndex = 60;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // DTGTrabajador
            // 
            this.DTGTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGTrabajador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.SalarioBase,
            this.Comision,
            this.PedidoXComision});
            this.DTGTrabajador.Location = new System.Drawing.Point(135, 199);
            this.DTGTrabajador.Name = "DTGTrabajador";
            this.DTGTrabajador.Size = new System.Drawing.Size(445, 176);
            this.DTGTrabajador.TabIndex = 61;
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
            this.Comision.HeaderText = "Comision";
            this.Comision.Name = "Comision";
            // 
            // PedidoXComision
            // 
            this.PedidoXComision.HeaderText = "PedidoXComision";
            this.PedidoXComision.Name = "PedidoXComision";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(611, 361);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(112, 23);
            this.cmdSalir.TabIndex = 62;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.Enabled = false;
            this.txtFechaFinal.Location = new System.Drawing.Point(447, 98);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(114, 29);
            this.txtFechaFinal.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "FechaFinal";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Enabled = false;
            this.txtFechaInicio.Location = new System.Drawing.Point(172, 99);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(116, 29);
            this.txtFechaInicio.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "FechaInicio";
            // 
            // Consultar_Salarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 396);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.DTGTrabajador);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.GBTrabajador);
            this.Name = "Consultar_Salarios";
            this.Text = "Consultar_Salarios";
            this.Load += new System.EventHandler(this.Consultar_Salarios_Load);
            this.GBTrabajador.ResumeLayout(false);
            this.GBTrabajador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGTrabajador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBTrabajador;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtProfesion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtNombreT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboTrabajador;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridView DTGTrabajador;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoXComision;
        private System.Windows.Forms.MaskedTextBox txtFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFechaInicio;
        private System.Windows.Forms.Label label2;
    }
}