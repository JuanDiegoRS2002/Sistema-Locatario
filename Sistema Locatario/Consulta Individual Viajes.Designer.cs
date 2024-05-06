namespace Sistema_Locatario
{
    partial class Consulta_Individual_Viajes
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
            this.label6 = new System.Windows.Forms.Label();
            this.CboTrabajador = new System.Windows.Forms.ComboBox();
            this.LBCategorias = new System.Windows.Forms.Label();
            this.DTGBusqueda = new System.Windows.Forms.DataGridView();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DTGP = new System.Windows.Forms.DataGridView();
            this.NumFruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrutaVerdura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadNecesitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEntregada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdTrabajador = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboViajes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGP)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Trabajador:";
            // 
            // CboTrabajador
            // 
            this.CboTrabajador.FormattingEnabled = true;
            this.CboTrabajador.Location = new System.Drawing.Point(239, 55);
            this.CboTrabajador.Name = "CboTrabajador";
            this.CboTrabajador.Size = new System.Drawing.Size(163, 21);
            this.CboTrabajador.TabIndex = 20;
            this.CboTrabajador.SelectedIndexChanged += new System.EventHandler(this.CboTrabajador_SelectedIndexChanged);
            // 
            // LBCategorias
            // 
            this.LBCategorias.AutoSize = true;
            this.LBCategorias.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCategorias.Location = new System.Drawing.Point(368, 5);
            this.LBCategorias.Name = "LBCategorias";
            this.LBCategorias.Size = new System.Drawing.Size(108, 47);
            this.LBCategorias.TabIndex = 47;
            this.LBCategorias.Text = "Viajes ";
            // 
            // DTGBusqueda
            // 
            this.DTGBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ciudad,
            this.Fecha,
            this.Hora,
            this.Prestamo});
            this.DTGBusqueda.Location = new System.Drawing.Point(12, 196);
            this.DTGBusqueda.Name = "DTGBusqueda";
            this.DTGBusqueda.Size = new System.Drawing.Size(796, 68);
            this.DTGBusqueda.TabIndex = 52;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Direccion";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 450;
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
            // Prestamo
            // 
            this.Prestamo.HeaderText = "Prestamo$";
            this.Prestamo.Name = "Prestamo";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(376, 146);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(112, 29);
            this.cmdBuscar.TabIndex = 53;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(239, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 20);
            this.txtNombre.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 55;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 57;
            this.label2.Text = "Profesion:";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(540, 99);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(163, 20);
            this.txtProfesion.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(696, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 59;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 47);
            this.label4.TabIndex = 60;
            this.label4.Text = "Datos del Viaje";
            // 
            // DTGP
            // 
            this.DTGP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumFruta,
            this.FrutaVerdura,
            this.CantidadNecesitada,
            this.CantidadEntregada});
            this.DTGP.Location = new System.Drawing.Point(12, 327);
            this.DTGP.Name = "DTGP";
            this.DTGP.Size = new System.Drawing.Size(461, 166);
            this.DTGP.TabIndex = 61;
            // 
            // NumFruta
            // 
            this.NumFruta.HeaderText = "NumFruta";
            this.NumFruta.Name = "NumFruta";
            // 
            // FrutaVerdura
            // 
            this.FrutaVerdura.HeaderText = "Fruta/Verdura";
            this.FrutaVerdura.Name = "FrutaVerdura";
            // 
            // CantidadNecesitada
            // 
            this.CantidadNecesitada.HeaderText = "Cantidad Necesitada";
            this.CantidadNecesitada.Name = "CantidadNecesitada";
            // 
            // CantidadEntregada
            // 
            this.CantidadEntregada.HeaderText = "CantidadEntregada";
            this.CantidadEntregada.Name = "CantidadEntregada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 47);
            this.label5.TabIndex = 62;
            this.label5.Text = "Datos de los Productos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 28);
            this.label7.TabIndex = 64;
            this.label7.Text = "Nombre:";
            // 
            // txtIdTrabajador
            // 
            this.txtIdTrabajador.Location = new System.Drawing.Point(239, 83);
            this.txtIdTrabajador.Name = "txtIdTrabajador";
            this.txtIdTrabajador.Size = new System.Drawing.Size(163, 20);
            this.txtIdTrabajador.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(418, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 28);
            this.label8.TabIndex = 66;
            this.label8.Text = "Numero Viaje";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // CboViajes
            // 
            this.CboViajes.FormattingEnabled = true;
            this.CboViajes.Location = new System.Drawing.Point(540, 72);
            this.CboViajes.Name = "CboViajes";
            this.CboViajes.Size = new System.Drawing.Size(163, 21);
            this.CboViajes.TabIndex = 65;
            this.CboViajes.SelectedIndexChanged += new System.EventHandler(this.CboViajes_SelectedIndexChanged);
            // 
            // Consulta_Individual_Viajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 505);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboViajes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdTrabajador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTGP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.DTGBusqueda);
            this.Controls.Add(this.LBCategorias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CboTrabajador);
            this.Name = "Consulta_Individual_Viajes";
            this.Text = "Viajes Consulta Individual";
            this.Load += new System.EventHandler(this.Consulta_Individual_Viajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboTrabajador;
        private System.Windows.Forms.Label LBCategorias;
        private System.Windows.Forms.DataGridView DTGBusqueda;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtProfesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DTGP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrutaVerdura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadNecesitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadEntregada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtIdTrabajador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboViajes;
    }
}