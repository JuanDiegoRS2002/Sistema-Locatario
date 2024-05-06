using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
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
    public partial class Consultar_Pedido : Form
    {

        MySqlConnection conexion;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Consultar_Pedido()
        {
            string servidor = "localhost";
            string bd = "sistemalocatario";
            string usuario = "root";
            string password = "";
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            conexion = new MySqlConnection(cadenaConexion);
            InitializeComponent();
        }

        private void Consultar_Pedido_Load(object sender, EventArgs e)
        {
            conexion.Open();
            actualizarDGV();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DTFBuscar.Value.Date;

            // Preparar la consulta SQL con parámetros
            string consulta = "SELECT P.Fecha, P.Hora, C.Nombre AS NombreCliente, F.Nombre AS NombreProducto, Dt.Precio, Dt.Cantidad, (Dt.Precio * Dt.Cantidad) As 'Importe' ,P.Total " +
                              "FROM detpedido AS Dt " +
                              "INNER JOIN pedido AS P ON Dt.IdPedido = P.IdPedido " +
                              "INNER JOIN cliente AS C ON P.IdCliente = C.IdCliente " +
                              "INNER JOIN frutasyverduras AS F ON Dt.IdFrutaVerdu = F.IdFrutaVerdu " +
                              "WHERE P.Fecha = @Fecha";

            // Limpiar el DataGridView antes de agregar nuevas filas
            DTGFrutas.Rows.Clear();

            // Ejecutar la consulta con parámetro de fecha
            using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
            {
                // Agregar el parámetro para la fecha
                comando.Parameters.AddWithValue("@Fecha", fechaSeleccionada);

                // Ejecutar la consulta y leer los resultados
                using (MySqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // Agregar cada fila al DataGridView
                        DTGFrutas.Rows.Add(
                            lector["Fecha"].ToString(),
                            lector["Hora"].ToString(),
                            lector["NombreCliente"].ToString(),
                            lector["NombreProducto"].ToString(),
                            lector["Precio"].ToString(),
                            lector["Cantidad"].ToString(),
                            lector["Importe"].ToString(),
                            lector["Total"].ToString()
                        );
                    }
                }
            }
        }

        public void actualizarDGV()
        {

        }
    }
}

 

