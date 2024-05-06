namespace Sistema_Locatario
{
    partial class SistemaLocatario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frutasVerdurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalXFechaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobroPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.generalXFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogosToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.frutasVerdurasToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.trabajadorToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // frutasVerdurasToolStripMenuItem
            // 
            this.frutasVerdurasToolStripMenuItem.Name = "frutasVerdurasToolStripMenuItem";
            this.frutasVerdurasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.frutasVerdurasToolStripMenuItem.Text = "Frutas/Verduras";
            this.frutasVerdurasToolStripMenuItem.Click += new System.EventHandler(this.frutasVerdurasToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // trabajadorToolStripMenuItem
            // 
            this.trabajadorToolStripMenuItem.Name = "trabajadorToolStripMenuItem";
            this.trabajadorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.trabajadorToolStripMenuItem.Text = "Trabajador";
            this.trabajadorToolStripMenuItem.Click += new System.EventHandler(this.trabajadorToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.cobroPedidoToolStripMenuItem,
            this.viajesProductoToolStripMenuItem,
            this.imprimirTicketToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem,
            this.xClienteToolStripMenuItem,
            this.generalXFechaToolStripMenuItem2});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // individualToolStripMenuItem
            // 
            this.individualToolStripMenuItem.Name = "individualToolStripMenuItem";
            this.individualToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.individualToolStripMenuItem.Text = "Individual";
            this.individualToolStripMenuItem.Click += new System.EventHandler(this.individualToolStripMenuItem_Click);
            // 
            // xClienteToolStripMenuItem
            // 
            this.xClienteToolStripMenuItem.Name = "xClienteToolStripMenuItem";
            this.xClienteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.xClienteToolStripMenuItem.Text = "X Cliente";
            this.xClienteToolStripMenuItem.Click += new System.EventHandler(this.xClienteToolStripMenuItem_Click);
            // 
            // generalXFechaToolStripMenuItem2
            // 
            this.generalXFechaToolStripMenuItem2.Name = "generalXFechaToolStripMenuItem2";
            this.generalXFechaToolStripMenuItem2.Size = new System.Drawing.Size(158, 22);
            this.generalXFechaToolStripMenuItem2.Text = "General X Fecha";
            this.generalXFechaToolStripMenuItem2.Click += new System.EventHandler(this.generalXFechaToolStripMenuItem2_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem1,
            this.consultarToolStripMenuItem1});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.registrarToolStripMenuItem1.Text = "Registrar";
            this.registrarToolStripMenuItem1.Click += new System.EventHandler(this.registrarToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreGeneralToolStripMenuItem,
            this.generalToolStripMenuItem});
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // porNombreGeneralToolStripMenuItem
            // 
            this.porNombreGeneralToolStripMenuItem.Name = "porNombreGeneralToolStripMenuItem";
            this.porNombreGeneralToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.porNombreGeneralToolStripMenuItem.Text = "Individual";
            this.porNombreGeneralToolStripMenuItem.Click += new System.EventHandler(this.porNombreGeneralToolStripMenuItem_Click);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // cobroPedidoToolStripMenuItem
            // 
            this.cobroPedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem2,
            this.consultarToolStripMenuItem2});
            this.cobroPedidoToolStripMenuItem.Name = "cobroPedidoToolStripMenuItem";
            this.cobroPedidoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cobroPedidoToolStripMenuItem.Text = "Cobro Pedido";
            // 
            // registrarToolStripMenuItem2
            // 
            this.registrarToolStripMenuItem2.Name = "registrarToolStripMenuItem2";
            this.registrarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.registrarToolStripMenuItem2.Text = "Registrar";
            this.registrarToolStripMenuItem2.Click += new System.EventHandler(this.registrarToolStripMenuItem2_Click);
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalXFechaToolStripMenuItem});
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            // 
            // generalXFechaToolStripMenuItem
            // 
            this.generalXFechaToolStripMenuItem.Name = "generalXFechaToolStripMenuItem";
            this.generalXFechaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.generalXFechaToolStripMenuItem.Text = "General X Fecha";
            this.generalXFechaToolStripMenuItem.Click += new System.EventHandler(this.generalXFechaToolStripMenuItem_Click);
            // 
            // viajesProductoToolStripMenuItem
            // 
            this.viajesProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem3,
            this.verificarToolStripMenuItem,
            this.consultarToolStripMenuItem3});
            this.viajesProductoToolStripMenuItem.Name = "viajesProductoToolStripMenuItem";
            this.viajesProductoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viajesProductoToolStripMenuItem.Text = "Viajes Producto";
            // 
            // registrarToolStripMenuItem3
            // 
            this.registrarToolStripMenuItem3.Name = "registrarToolStripMenuItem3";
            this.registrarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.registrarToolStripMenuItem3.Text = "Registrar";
            this.registrarToolStripMenuItem3.Click += new System.EventHandler(this.registrarToolStripMenuItem3_Click);
            // 
            // verificarToolStripMenuItem
            // 
            this.verificarToolStripMenuItem.Name = "verificarToolStripMenuItem";
            this.verificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.verificarToolStripMenuItem.Text = "Verificar";
            this.verificarToolStripMenuItem.Click += new System.EventHandler(this.verificarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem3
            // 
            this.consultarToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem1});
            this.consultarToolStripMenuItem3.Name = "consultarToolStripMenuItem3";
            this.consultarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem3.Text = "Consultar";
            // 
            // individualToolStripMenuItem1
            // 
            this.individualToolStripMenuItem1.Name = "individualToolStripMenuItem1";
            this.individualToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.individualToolStripMenuItem1.Text = "Individual";
            this.individualToolStripMenuItem1.Click += new System.EventHandler(this.individualToolStripMenuItem1_Click);
            // 
            // imprimirTicketToolStripMenuItem
            // 
            this.imprimirTicketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fruToolStripMenuItem,
            this.salariosToolStripMenuItem,
            this.cobrosToolStripMenuItem,
            this.viajesToolStripMenuItem});
            this.imprimirTicketToolStripMenuItem.Name = "imprimirTicketToolStripMenuItem";
            this.imprimirTicketToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.imprimirTicketToolStripMenuItem.Text = "Imprimir Ticket";
            // 
            // fruToolStripMenuItem
            // 
            this.fruToolStripMenuItem.Name = "fruToolStripMenuItem";
            this.fruToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.fruToolStripMenuItem.Text = "Pedido";
            // 
            // salariosToolStripMenuItem
            // 
            this.salariosToolStripMenuItem.Name = "salariosToolStripMenuItem";
            this.salariosToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.salariosToolStripMenuItem.Text = "Pagos";
            // 
            // cobrosToolStripMenuItem
            // 
            this.cobrosToolStripMenuItem.Name = "cobrosToolStripMenuItem";
            this.cobrosToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.cobrosToolStripMenuItem.Text = "Cobros";
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.viajesToolStripMenuItem.Text = "Viajes";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // SistemaLocatario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SistemaLocatario";
            this.Text = "Sistema Locatario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frutasVerdurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imprimirTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobroPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem generalXFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cobrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalXFechaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verificarToolStripMenuItem;
    }
}

