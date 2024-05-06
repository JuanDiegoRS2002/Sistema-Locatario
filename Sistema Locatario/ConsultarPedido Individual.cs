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
    public partial class ConsultarPedido_Individual : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public ConsultarPedido_Individual()
        {
            string servidor = "localhost";
            string bd = "sistemalocatario";
            string usuario = "root";
            string password = "";
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            conexion = new MySqlConnection(cadenaConexion);
            InitializeComponent();
        }

        private void ConsultarPedido_Individual_Load(object sender, EventArgs e)
        {
            conexion.Open();

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string consultaDetallePedidos = "SELECT P.IdPedido As Pedido, C.Nombre AS NombreCliente, F.Nombre AS NombreProducto, Dt.Precio, Dt.Cantidad, (Dt.Precio * Dt.Cantidad) As 'Importe' ,P.Total " +
                               "FROM detpedido AS Dt " +
                               "INNER JOIN pedido AS P ON Dt.IdPedido = P.IdPedido " +
                               "INNER JOIN cliente AS C ON P.IdCliente = C.IdCliente " +
                               "INNER JOIN frutasyverduras AS F ON Dt.IdFrutaVerdu = F.IdFrutaVerdu " +
                               "WHERE P.IdPedido = @Pedido";

            DTGFrutas.Rows.Clear();

            MySqlCommand comandoDetallePedidos = new MySqlCommand(consultaDetallePedidos, conexion);
            comandoDetallePedidos.Parameters.AddWithValue("@Pedido", txtIdPedido.Text);
            MySqlDataReader lectorDetallePedidos = comandoDetallePedidos.ExecuteReader();


            if (lectorDetallePedidos.Read())
            {
                // Obtener el valor del campo "Total" del primer registro
                string totalPedido = lectorDetallePedidos["Total"].ToString();

                // Agregar el primer registro al DataGridView
                DTGFrutas.Rows.Add(
                    lectorDetallePedidos["Pedido"].ToString(),
                    lectorDetallePedidos["NombreCliente"].ToString(),
                    lectorDetallePedidos["NombreProducto"].ToString(),
                    lectorDetallePedidos["Precio"].ToString(),
                    lectorDetallePedidos["Cantidad"].ToString(),
                    lectorDetallePedidos["Importe"].ToString(),
                    totalPedido
                );

                // Continuar leyendo los registros restantes y agregarlos al DataGridView
                while (lectorDetallePedidos.Read())
                {
                    DTGFrutas.Rows.Add(
                        lectorDetallePedidos["Pedido"].ToString(),
                        lectorDetallePedidos["NombreCliente"].ToString(),
                        lectorDetallePedidos["NombreProducto"].ToString(),
                        lectorDetallePedidos["Precio"].ToString(),
                        lectorDetallePedidos["Cantidad"].ToString(),
                        lectorDetallePedidos["Importe"].ToString(),
                        "" // Dejar el campo "Total" vacío para las filas restantes
                    );
                }
            }
            lectorDetallePedidos.Close();
        }
    }
 }
