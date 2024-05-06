namespace Sistema_Locatario
{
    partial class Pedidos
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
            this.LBCategorias = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTF = new System.Windows.Forms.DateTimePicker();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdInsertar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.DTGFrutas = new System.Windows.Forms.DataGridView();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrutaOVerdura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.CboHora = new System.Windows.Forms.ComboBox();
            this.GBCliente = new System.Windows.Forms.GroupBox();
            this.txtIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.GBTrabajador = new System.Windows.Forms.GroupBox();
            this.IdTrabajador = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreT = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboTrabajador = new System.Windows.Forms.ComboBox();
            this.GBFrutasYVerduras = new System.Windows.Forms.GroupBox();
            this.txtExistencias = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtIdFrutaVerdu = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CBMayoreo = new System.Windows.Forms.CheckBox();
            this.CBMenudeo = new System.Windows.Forms.CheckBox();
            this.txtIdCategoria = new System.Windows.Forms.MaskedTextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreFV = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CboFrutaVerdura = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.IdPedido = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTGFrutas)).BeginInit();
            this.GBCliente.SuspendLayout();
            this.GBTrabajador.SuspendLayout();
            this.GBFrutasYVerduras.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBCategorias
            // 
            this.LBCategorias.AutoSize = true;
            this.LBCategorias.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCategorias.Location = new System.Drawing.Point(352, -1);
            this.LBCategorias.Name = "LBCategorias";
            this.LBCategorias.Size = new System.Drawing.Size(125, 47);
            this.LBCategorias.TabIndex = 1;
            this.LBCategorias.Text = "Pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora:";
            // 
            // DTF
            // 
            this.DTF.Location = new System.Drawing.Point(88, 57);
            this.DTF.Name = "DTF";
            this.DTF.Size = new System.Drawing.Size(200, 20);
            this.DTF.TabIndex = 6;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(589, 533);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(112, 23);
            this.cmdNuevo.TabIndex = 32;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdInsertar
            // 
            this.cmdInsertar.Location = new System.Drawing.Point(479, 137);
            this.cmdInsertar.Name = "cmdInsertar";
            this.cmdInsertar.Size = new System.Drawing.Size(112, 38);
            this.cmdInsertar.TabIndex = 33;
            this.cmdInsertar.Text = "Inserta";
            this.cmdInsertar.UseVisualStyleBackColor = true;
            this.cmdInsertar.Click += new System.EventHandler(this.cmdInsertar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(589, 585);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(112, 23);
            this.cmdGrabar.TabIndex = 34;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // DTGFrutas
            // 
            this.DTGFrutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGFrutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Concepto,
            this.FrutaOVerdura,
            this.Precio,
            this.Cantidad,
            this.Subtotala});
            this.DTGFrutas.Enabled = false;
            this.DTGFrutas.Location = new System.Drawing.Point(9, 534);
            this.DTGFrutas.Name = "DTGFrutas";
            this.DTGFrutas.Size = new System.Drawing.Size(574, 105);
            this.DTGFrutas.TabIndex = 35;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "IdFrutaVerdura";
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
            // Subtotala
            // 
            this.Subtotala.HeaderText = "Importe";
            this.Subtotala.Name = "Subtotala";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(589, 639);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(112, 23);
            this.cmdSalir.TabIndex = 36;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // CboHora
            // 
            this.CboHora.FormattingEnabled = true;
            this.CboHora.Location = new System.Drawing.Point(618, 56);
            this.CboHora.Name = "CboHora";
            this.CboHora.Size = new System.Drawing.Size(163, 21);
            this.CboHora.TabIndex = 41;
            this.CboHora.SelectedIndexChanged += new System.EventHandler(this.CboHora_SelectedIndexChanged);
            // 
            // GBCliente
            // 
            this.GBCliente.Controls.Add(this.txtIdCliente);
            this.GBCliente.Controls.Add(this.label19);
            this.GBCliente.Controls.Add(this.txtTelefono);
            this.GBCliente.Controls.Add(this.label5);
            this.GBCliente.Controls.Add(this.txtNombre);
            this.GBCliente.Controls.Add(this.label4);
            this.GBCliente.Controls.Add(this.label3);
            this.GBCliente.Controls.Add(this.CboCliente);
            this.GBCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCliente.Location = new System.Drawing.Point(13, 77);
            this.GBCliente.Name = "GBCliente";
            this.GBCliente.Size = new System.Drawing.Size(601, 138);
            this.GBCliente.TabIndex = 42;
            this.GBCliente.TabStop = false;
            this.GBCliente.Text = "Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(416, 28);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(154, 29);
            this.txtIdCliente.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(325, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 28);
            this.label19.TabIndex = 26;
            this.label19.Text = "Numero#";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(439, 80);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(145, 29);
            this.txtTelefono.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(126, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 29);
            this.txtNombre.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente";
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(152, 28);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(163, 32);
            this.CboCliente.TabIndex = 12;
            this.CboCliente.SelectedIndexChanged += new System.EventHandler(this.CboCliente_SelectedIndexChanged);
            // 
            // GBTrabajador
            // 
            this.GBTrabajador.Controls.Add(this.IdTrabajador);
            this.GBTrabajador.Controls.Add(this.label17);
            this.GBTrabajador.Controls.Add(this.txtProfesion);
            this.GBTrabajador.Controls.Add(this.label7);
            this.GBTrabajador.Controls.Add(this.txtNombreT);
            this.GBTrabajador.Controls.Add(this.label8);
            this.GBTrabajador.Controls.Add(this.label6);
            this.GBTrabajador.Controls.Add(this.CboTrabajador);
            this.GBTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTrabajador.Location = new System.Drawing.Point(13, 221);
            this.GBTrabajador.Name = "GBTrabajador";
            this.GBTrabajador.Size = new System.Drawing.Size(703, 100);
            this.GBTrabajador.TabIndex = 43;
            this.GBTrabajador.TabStop = false;
            this.GBTrabajador.Text = "Trabajador";
            // 
            // IdTrabajador
            // 
            this.IdTrabajador.Enabled = false;
            this.IdTrabajador.Location = new System.Drawing.Point(483, 20);
            this.IdTrabajador.Name = "IdTrabajador";
            this.IdTrabajador.Size = new System.Drawing.Size(154, 29);
            this.IdTrabajador.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(392, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 28);
            this.label17.TabIndex = 24;
            this.label17.Text = "Numero#";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Enabled = false;
            this.txtProfesion.Location = new System.Drawing.Point(434, 65);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(165, 29);
            this.txtProfesion.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "Profesion:";
            // 
            // txtNombreT
            // 
            this.txtNombreT.Enabled = false;
            this.txtNombreT.Location = new System.Drawing.Point(121, 63);
            this.txtNombreT.Name = "txtNombreT";
            this.txtNombreT.Size = new System.Drawing.Size(154, 29);
            this.txtNombreT.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Trabajador";
            // 
            // CboTrabajador
            // 
            this.CboTrabajador.FormattingEnabled = true;
            this.CboTrabajador.Location = new System.Drawing.Point(215, 20);
            this.CboTrabajador.Name = "CboTrabajador";
            this.CboTrabajador.Size = new System.Drawing.Size(163, 32);
            this.CboTrabajador.TabIndex = 18;
            this.CboTrabajador.SelectedIndexChanged += new System.EventHandler(this.CboTrabajador_SelectedIndexChanged);
            // 
            // GBFrutasYVerduras
            // 
            this.GBFrutasYVerduras.Controls.Add(this.txtExistencias);
            this.GBFrutasYVerduras.Controls.Add(this.label20);
            this.GBFrutasYVerduras.Controls.Add(this.txtIdFrutaVerdu);
            this.GBFrutasYVerduras.Controls.Add(this.label18);
            this.GBFrutasYVerduras.Controls.Add(this.CBMayoreo);
            this.GBFrutasYVerduras.Controls.Add(this.CBMenudeo);
            this.GBFrutasYVerduras.Controls.Add(this.txtIdCategoria);
            this.GBFrutasYVerduras.Controls.Add(this.Numero);
            this.GBFrutasYVerduras.Controls.Add(this.cmdInsertar);
            this.GBFrutasYVerduras.Controls.Add(this.txtPrecio);
            this.GBFrutasYVerduras.Controls.Add(this.label13);
            this.GBFrutasYVerduras.Controls.Add(this.txtCantidad);
            this.GBFrutasYVerduras.Controls.Add(this.label11);
            this.GBFrutasYVerduras.Controls.Add(this.txtNombreFV);
            this.GBFrutasYVerduras.Controls.Add(this.label12);
            this.GBFrutasYVerduras.Controls.Add(this.label10);
            this.GBFrutasYVerduras.Controls.Add(this.CboFrutaVerdura);
            this.GBFrutasYVerduras.Controls.Add(this.label9);
            this.GBFrutasYVerduras.Controls.Add(this.CboCategoria);
            this.GBFrutasYVerduras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFrutasYVerduras.Location = new System.Drawing.Point(6, 327);
            this.GBFrutasYVerduras.Name = "GBFrutasYVerduras";
            this.GBFrutasYVerduras.Size = new System.Drawing.Size(775, 198);
            this.GBFrutasYVerduras.TabIndex = 44;
            this.GBFrutasYVerduras.TabStop = false;
            this.GBFrutasYVerduras.Text = "Frutas Y Verduras";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Enabled = false;
            this.txtExistencias.Location = new System.Drawing.Point(651, 68);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(100, 29);
            this.txtExistencias.TabIndex = 64;
            this.txtExistencias.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtExistencias_MaskInputRejected);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(544, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 28);
            this.label20.TabIndex = 63;
            this.label20.Text = "Existencias:";
            // 
            // txtIdFrutaVerdu
            // 
            this.txtIdFrutaVerdu.Enabled = false;
            this.txtIdFrutaVerdu.Location = new System.Drawing.Point(148, 133);
            this.txtIdFrutaVerdu.Name = "txtIdFrutaVerdu";
            this.txtIdFrutaVerdu.Size = new System.Drawing.Size(163, 29);
            this.txtIdFrutaVerdu.TabIndex = 62;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(57, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 28);
            this.label18.TabIndex = 61;
            this.label18.Text = "Numero:";
            // 
            // CBMayoreo
            // 
            this.CBMayoreo.AutoSize = true;
            this.CBMayoreo.Location = new System.Drawing.Point(547, 27);
            this.CBMayoreo.Name = "CBMayoreo";
            this.CBMayoreo.Size = new System.Drawing.Size(110, 28);
            this.CBMayoreo.TabIndex = 60;
            this.CBMayoreo.Text = "Mayoreo";
            this.CBMayoreo.UseVisualStyleBackColor = true;
            this.CBMayoreo.CheckedChanged += new System.EventHandler(this.CBMayoreo_CheckedChanged);
            // 
            // CBMenudeo
            // 
            this.CBMenudeo.AutoSize = true;
            this.CBMenudeo.Location = new System.Drawing.Point(419, 27);
            this.CBMenudeo.Name = "CBMenudeo";
            this.CBMenudeo.Size = new System.Drawing.Size(118, 28);
            this.CBMenudeo.TabIndex = 59;
            this.CBMenudeo.Text = "Menudeo";
            this.CBMenudeo.UseVisualStyleBackColor = true;
            this.CBMenudeo.CheckedChanged += new System.EventHandler(this.CBMenudeo_CheckedChanged);
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Enabled = false;
            this.txtIdCategoria.Location = new System.Drawing.Point(148, 67);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(163, 29);
            this.txtIdCategoria.TabIndex = 58;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(57, 67);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(78, 28);
            this.Numero.TabIndex = 57;
            this.Numero.Text = "Numero:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(404, 102);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(163, 29);
            this.txtPrecio.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(334, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 28);
            this.label13.TabIndex = 49;
            this.label13.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(441, 67);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 29);
            this.txtCantidad.TabIndex = 48;
            this.txtCantidad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCantidad_MaskInputRejected);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(327, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 28);
            this.label11.TabIndex = 47;
            this.label11.Text = "Cantidad KG:";
            // 
            // txtNombreFV
            // 
            this.txtNombreFV.Enabled = false;
            this.txtNombreFV.Location = new System.Drawing.Point(93, 168);
            this.txtNombreFV.Name = "txtNombreFV";
            this.txtNombreFV.Size = new System.Drawing.Size(163, 29);
            this.txtNombreFV.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 28);
            this.label12.TabIndex = 45;
            this.label12.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 28);
            this.label10.TabIndex = 44;
            this.label10.Text = "Frutas/Verduras:";
            // 
            // CboFrutaVerdura
            // 
            this.CboFrutaVerdura.FormattingEnabled = true;
            this.CboFrutaVerdura.Location = new System.Drawing.Point(148, 99);
            this.CboFrutaVerdura.Name = "CboFrutaVerdura";
            this.CboFrutaVerdura.Size = new System.Drawing.Size(163, 32);
            this.CboFrutaVerdura.TabIndex = 43;
            this.CboFrutaVerdura.SelectedIndexChanged += new System.EventHandler(this.CboFrutaVerdura_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 28);
            this.label9.TabIndex = 42;
            this.label9.Text = "Categoria";
            // 
            // CboCategoria
            // 
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(148, 31);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(163, 32);
            this.CboCategoria.TabIndex = 41;
            this.CboCategoria.SelectedIndexChanged += new System.EventHandler(this.CboCategoria_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(452, 651);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(390, 643);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 28);
            this.label15.TabIndex = 51;
            this.label15.Text = "Total:";
            // 
            // IdPedido
            // 
            this.IdPedido.Enabled = false;
            this.IdPedido.Location = new System.Drawing.Point(389, 58);
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.Size = new System.Drawing.Size(154, 20);
            this.IdPedido.TabIndex = 19;
            this.IdPedido.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.IdPedido_MaskInputRejected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(307, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 28);
            this.label14.TabIndex = 18;
            this.label14.Text = "Numero#";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.IdPedido);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.GBFrutasYVerduras);
            this.Controls.Add(this.GBTrabajador);
            this.Controls.Add(this.GBCliente);
            this.Controls.Add(this.CboHora);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.DTGFrutas);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.DTF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBCategorias);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGFrutas)).EndInit();
            this.GBCliente.ResumeLayout(false);
            this.GBCliente.PerformLayout();
            this.GBTrabajador.ResumeLayout(false);
            this.GBTrabajador.PerformLayout();
            this.GBFrutasYVerduras.ResumeLayout(false);
            this.GBFrutasYVerduras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTF;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdInsertar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.DataGridView DTGFrutas;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.ComboBox CboHora;
        private System.Windows.Forms.GroupBox GBCliente;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.GroupBox GBTrabajador;
        private System.Windows.Forms.MaskedTextBox txtProfesion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtNombreT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboTrabajador;
        private System.Windows.Forms.GroupBox GBFrutasYVerduras;
        private System.Windows.Forms.MaskedTextBox txtNombreFV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CboFrutaVerdura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.MaskedTextBox txtIdCategoria;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.MaskedTextBox IdPedido;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox IdTrabajador;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtIdFrutaVerdu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtIdCliente;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox CBMayoreo;
        private System.Windows.Forms.CheckBox CBMenudeo;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtExistencias;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox txtTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrutaOVerdura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotala;
    }
}