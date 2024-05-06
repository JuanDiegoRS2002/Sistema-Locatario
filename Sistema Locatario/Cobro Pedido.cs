using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;

namespace Sistema_Locatario
{
    public partial class Cobro_Pedido : Form
    {

        MySqlConnection conexion;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Cobro_Pedido()
        {
            string servidor = "localhost";
            string bd = "sistemalocatario";
            string usuario = "root";
            string password = "";
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            conexion = new MySqlConnection(cadenaConexion);
            InitializeComponent();
        }

        private void Cobro_Pedido_Load(object sender, EventArgs e)
        {
            conexion.Open();
            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM cliente";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                CboCliente.Items.Add(lector.GetString(1));
            }
            lector.Close();

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM pedido";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                CboNumPedido.Items.Add(lector.GetInt32(0).ToString());
            }
            lector.Close();
        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM cliente WHERE Nombre='" + CboCliente.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            lector.Read();
            txtIdCliente.Text = lector[0].ToString();
            txtNombre.Text = lector[1].ToString();
            txtTelefono.Text = lector[2].ToString();
            lector.Close();


            consulta = "SELECT IdPedido FROM pedido WHERE IdCliente=@IdCliente AND Statu <> 'c'";
            comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@IdCliente", txtIdCliente.Text);

            lector = comando.ExecuteReader();

            // Limpiar los elementos anteriores de la ComboBox
            CboNumPedido.Items.Clear();

            while (lector.Read())
            {
                CboNumPedido.Items.Add(lector.GetInt32(0).ToString());

            }

            lector.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {


            // Establecer la consulta SQL
            string consultaPedidos = "SELECT P.IdPedido, F.Nombre, Dt.Precio, Dt.Cantidad, (Dt.Precio * Dt.Cantidad) As 'Importe' ,P.Total " +
                         "FROM detpedido AS Dt " +
                         "INNER JOIN pedido AS P ON Dt.IdPedido = P.IdPedido " +
                         "INNER JOIN frutasyverduras AS F ON Dt.IdFrutaVerdu = F.IdFrutaVerdu " +
                         "WHERE P.IdCliente = @IdCliente AND P.Statu <> 'c'";

            MySqlCommand comandoPedidos = new MySqlCommand(consultaPedidos, conexion);
            comandoPedidos.Parameters.AddWithValue("@IdCliente", txtIdCliente.Text);

            MySqlDataReader lector = comandoPedidos.ExecuteReader();

            DTGFrutas.Rows.Clear();

            // Iteramos a través de los resultados y los mostramos en el DataGridView
            while (lector.Read())
            {
                // Agregar cada fila al DataGridView
                DTGFrutas.Rows.Add(
                    lector["IdPedido"].ToString(),
                    lector["Nombre"].ToString(),
                    lector["Precio"].ToString(),
                    lector["Cantidad"].ToString(),
                    lector["Importe"].ToString()
                    
                );
            }

            lector.Close();

        }

        private void CboNumPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT Total FROM pedido WHERE IdPedido=@IdPedido";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@IdPedido", CboNumPedido.SelectedItem.ToString());

            MySqlDataReader lectorTotalPedido = comando.ExecuteReader();
            if (lectorTotalPedido.Read())
            {
                txtTotal.Text = lectorTotalPedido["Total"].ToString();
                txtDineroIngresar.Enabled = true;
            }
            else
            {
                txtTotal.Text = ""; // Limpiar el texto si no se encuentra un pedido
                txtDineroIngresar.Enabled = false;
            }

            lectorTotalPedido.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT COUNT(*) FROM cobropedido", conexion);
            object result = comando.ExecuteScalar();
            if (result != null)
            {
                int n;
                if (int.TryParse(result.ToString(), out n))
                {
                    n++; // Incrementa en 1
                    txtIdCobro.Text = n.ToString();
                }
                else
                {

                }

                txtDineroIngresar.Text = "";
                txtIdCliente.Text = "";
                txtNombre.Text= "";
                txtTelefono.Text= "";
                txtTotal.Text= "";
                CboCliente.Text = "";
                CboNumPedido.Text = "";
                DTGFrutas.Rows.Clear();
            

            }
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            decimal importePedido = decimal.Parse(txtTotal.Text);
            decimal dineroIngresar = decimal.Parse(txtDineroIngresar.Text);

            // Verificar si el dinero a ingresar es menor o igual al importe del pedido
            if (dineroIngresar >= importePedido)
            {
                // Agregar la fila al DataGridView
                string fecha = DTFCobro.Value.ToString("yyyy-MM-dd");
               
            }
            else
            {
                // Mostrar un mensaje de error o tomar alguna otra acción
                MessageBox.Show("El dinero a ingresar es menor al importe del pedido. No se puede agregar.");
            }
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string fecha = DTFCobro.Value.Year + "-" + DTFCobro.Value.Month + "-" + DTFCobro.Value.Day;
            string query = "INSERT INTO cobropedido (IdPedido, Fecha, Importe) VALUES ('" +
                CboNumPedido.Text + "', '" +
                fecha + "', '" +
                txtDineroIngresar.Text+ "')";

            MessageBox.Show(query);

            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            string queryActualizar = "UPDATE pedido SET Statu = 'c' WHERE IdPedido = @IdPedido";

            MySqlCommand comandoActualizar = new MySqlCommand(queryActualizar, conexion);
            comandoActualizar.Parameters.AddWithValue("@IdPedido", CboNumPedido.Text);


            comandoActualizar.ExecuteNonQuery();
        }
    }
    }

