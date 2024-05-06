using MySql.Data.MySqlClient;
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
    public partial class ConsultarGeneral_CobroPedido : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public ConsultarGeneral_CobroPedido()
        {
            string servidor = "localhost";
            string bd = "sistemalocatario";
            string usuario = "root";
            string password = "";
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            conexion = new MySqlConnection(cadenaConexion);
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DTFA.Value.Date;
            string consulta = "SELECT C.Nombre, P.IdPedido, P.Fecha AS FechaPedido, CB.Fecha AS FechaCobro, P.Total, CB.Importe " +
                  "FROM cliente AS C " +
                  "INNER JOIN pedido AS P ON C.IdCliente = P.IdCliente " +
                  "INNER JOIN cobropedido AS CB ON P.IdPedido = CB.IdPedido " +
                  "WHERE DATE(CB.Fecha) = @FechaCobro";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@FechaCobro", fechaSeleccionada);

            DTGC.Rows.Clear();

            decimal totalDia = 0;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                // Agregar cada fila al DataGridView
                DTGC.Rows.Add(
                    lector["Nombre"].ToString(),
                    lector["IdPedido"].ToString(),
                    lector["FechaPedido"].ToString(),
                    lector["FechaCobro"].ToString(),
                    lector["Total"].ToString(),
                    lector["Importe"].ToString()
                    
                );
                totalDia += Convert.ToDecimal(lector["Importe"]);
            }
            DTGC.Rows.Add("", "", "", "", "", " ", totalDia.ToString());
            lector.Close();
            
        }

        private void ConsultarGeneral_CobroPedido_Load(object sender, EventArgs e)
        {
            conexion.Open();
            //actualizarDGV();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }
    }
}
