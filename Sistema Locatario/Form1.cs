using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Locatario
{
    public partial class SistemaLocatario : Form
    {
        public SistemaLocatario()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias cat = new Categorias();
            cat.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Show();
        }

        private void trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trabajador tra = new Trabajador();
            tra.Show();
        }

        private void frutasVerdurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrutasVerduras FruV = new FrutasVerduras();
            FruV.Show();   
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Consultar_FrutasyVerduras CfRUV = new Consultar_FrutasyVerduras();
            CfRUV.Show();   
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos Pd1 = new Pedidos();
            Pd1.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaldosTrabajadores St = new SaldosTrabajadores();
            St.Show();
        }

        private void porNombreGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_Salarios CS = new Consultar_Salarios();
            CS.Show();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultorio_SalariosGeneral Csa = new Consultorio_SalariosGeneral();
            Csa.Show();
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cobro_Pedido Cp = new Cobro_Pedido();
            Cp.Show();
        }

        private void generalXFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarGeneral_CobroPedido CS = new ConsultarGeneral_CobroPedido();
            CS.Show();
        }

        private void generalXFechaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Consultar_Pedido Cp = new Consultar_Pedido();
            Cp.Show();
        }

        private void xClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_PedidosIndividual CxC = new Consultar_PedidosIndividual();
            CxC.Show();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPedido_Individual PC = new ConsultarPedido_Individual();
            PC.Show();
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ViajesXProducto_Registrar VP = new ViajesXProducto_Registrar();
            VP.Show();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Individual_Viajes VPI = new Consulta_Individual_Viajes();
            VPI.Show();
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verificar_ViajeXProducto VR = new Verificar_ViajeXProducto();
            VR.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORTES RP = new REPORTES();
            RP.Show();
        }
    }
}
