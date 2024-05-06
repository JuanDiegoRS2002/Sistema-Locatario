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
    public partial class SaldosTrabajadores : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        double total;
        public SaldosTrabajadores()
        {
            string servidor = "localhost";
            string bd = "sistemalocatario";
            string usuario = "root";
            string password = "";
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";
            conexion = new MySqlConnection(cadenaConexion);
            InitializeComponent();
        }

        private void SaldosTrabajadores_Load(object sender, EventArgs e)
        {
            conexion.Open();

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM trabajador";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                CboTrabajador.Items.Add(lector.GetString(1));
            }
            lector.Close();
        }

        private void CboTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM trabajador WHERE Nombre='" + CboTrabajador.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            lector.Read();
            txtNumero.Text = lector[0].ToString();
            txtNombreT.Text = lector[1].ToString();
            txtProfesion.Text = lector[3].ToString();
            lector.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaantes = DTFA.Value.Date;
            DateTime fechadespues = DTFD.Value.Date.AddDays(1); // Agregar un día para incluir la fecha final

            // Preparar la consulta SQL con parámetros
            string consulta = "SELECT T.Nombre AS 'Nombre', P.Fecha AS 'Fecha', P.Total AS 'Total' " +
                      "FROM pedido P " +
                      "INNER JOIN trabajador T ON P.IdTrabajador = T.IdTrabajador " +
                      "WHERE T.IdTrabajador = @IdTrabajador " +
                      "AND P.Fecha >= @FechaAntes AND P.Fecha <= @FechaDespues " +
                      "AND P.StatuT <> 'SiC'";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            // Asignar parámetros
            comando.Parameters.AddWithValue("@IDTrabajador", txtNumero.Text);
            comando.Parameters.AddWithValue("@FechaAntes", DTFA.Value.Date);
            comando.Parameters.AddWithValue("@FechaDespues", DTFD.Value.Date.AddDays(1));

            try
            {

                MySqlDataReader reader = comando.ExecuteReader();

                // Limpiar filas existentes en el DataGridView
                DTVBuscar.Rows.Clear();

                int contadorPedidos = 0;
                // Leer los datos y agregarlos al DataGridView
                while (reader.Read())
                {
                    // Agregar una nueva fila con los datos del lector
                    DTVBuscar.Rows.Add(reader["Nombre"].ToString(), reader["Fecha"].ToString(), reader["Total"].ToString());
                    contadorPedidos++;
                }
                txtPedidosRealizados.Text = contadorPedidos.ToString();


                reader.Close(); // Cerrar el lector después de usarlo
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.Message);
            }
        }

      

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            double totalPedido = 0;

            // Verificar si el usuario ingresó un porcentaje de comisión válido
            if (!double.TryParse(txtPorcentajeComision.Text, out double porcentajeComision))
            {
                MessageBox.Show("Porcentaje de comisión no válido");
                return;
            }

            // Convertir el porcentaje a un valor entre 0 y 1
            porcentajeComision /= 100.0;

            // Iterar sobre las filas del DataGridView
            foreach (DataGridViewRow fila in DTVBuscar.Rows)
            {
                // Obtener el valor de la columna 'Total' y sumarlo al totalPedido
                if (fila.Cells["Total"].Value != null)
                {
                    totalPedido += Convert.ToDouble(fila.Cells["Total"].Value);
                }
            }

            // Calcular la comisión
            double comision = totalPedido * porcentajeComision;

            // Mostrar la comisión en un TextBox
            txtComision.Text = comision.ToString();
            total = Convert.ToDouble(txtComision.Text) + Convert.ToDouble(txtSueldoBase.Text);
            txtTotalComision.Text = total.ToString();
            DTGTrabajador.Rows.Add(CboTrabajador.Text, txtSueldoBase.Text, txtPorcentajeComision.Text, txtComision.Text, txtTotalComision.Text);
        }

        private void txtIdSalario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            MySqlCommand comando1 = new MySqlCommand("SELECT COUNT(*) FROM salarios", conexion);
            object result = comando1.ExecuteScalar();
            if (result != null)
            {
                int n;
                if (int.TryParse(result.ToString(), out n))
                {
                    n++; // Incrementa en 1
                    txtIdSalario.Text = n.ToString();
                }
                else
                {

                }
            }
            txtComision.Text = "";
            txtNombreT.Text = "";
            txtNumero.Text = "";
            txtPedidosRealizados.Text = "";
            txtPorcentajeComision.Text = "";
            txtProfesion.Text = "";
            txtSueldoBase.Text = "";
            txtTotalComision.Text = "";
            CboTrabajador.Text = "";

            DTGTrabajador.Rows.Clear();
            DTVBuscar.Rows.Clear();



        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string fecha = DTF.Value.Year + "-" + DTF.Value.Month + "-" + DTF.Value.Day;
            string fecha2 = DTFA.Value.Year + "-" + DTFA.Value.Month + "-" + DTFA.Value.Day;
            string fecha3 = DTFD.Value.Year + "-" + DTFD.Value.Month + "-" + DTFD.Value.Day;

            string query = "INSERT INTO salarios (IdTrabajador, Fecha, FechaAntes, FechaDespues, SalarioBase, Comision, ComisionXPedido) VALUES ('" +
                txtNumero.Text + "', '" +
                fecha + "', '" +
                fecha2 + "', '" +
                fecha3 + "', '" +
                txtSueldoBase.Text + "', '" +
                txtPorcentajeComision.Text + "', '" +
                txtComision.Text + "')";

            MessageBox.Show(query);

            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            string queryActualizar = "UPDATE pedido SET StatuT = 'SiC' WHERE IdTrabajador = @IdTrabajador AND Fecha BETWEEN @FechaAntes AND @FechaDespues";

            MySqlCommand comandoActualizar = new MySqlCommand(queryActualizar, conexion);
            comandoActualizar.Parameters.AddWithValue("@IdTrabajador", txtNumero.Text);
            comandoActualizar.Parameters.AddWithValue("@FechaAntes", DTFA.Value.Date);
            comandoActualizar.Parameters.AddWithValue("@FechaDespues", DTFD.Value.Date.AddDays(1));

            comandoActualizar.ExecuteNonQuery();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }
    }
}

