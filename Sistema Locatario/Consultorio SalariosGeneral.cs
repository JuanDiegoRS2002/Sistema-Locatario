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
using MySql.Data.MySqlClient;


namespace Sistema_Locatario
{
    public partial class Consultorio_SalariosGeneral : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Consultorio_SalariosGeneral()
        {
            string servidor = "localhost";
            string bd = "sistemalocatario";
            string usuario = "root";
            string password = "";
            string datos = null;
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            conexion = new MySqlConnection(cadenaConexion);
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaAntes = DTFA.Value.Date;
            DateTime fechaDespues = DTFD.Value.Date.AddDays(1); // Agregar un día para incluir la fecha final

            // Preparar la consulta SQL con parámetros
            string consulta = "SELECT T.Nombre AS 'Nombre', S.Fecha AS 'Fecha', S.SalarioBase AS 'SalarioBase', S.Comision AS 'Comisión', S.ComisionXPedido AS 'ComisiónXPedido', (S.SalarioBase + S.ComisionXPedido) As 'SalarioTotal' " +
                              "FROM salarios S " +
                              "INNER JOIN trabajador T ON S.IdTrabajador = T.IdTrabajador " +
                              "WHERE S.Fecha >= @FechaAntes AND S.Fecha <= @FechaDespues";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            // Asignar parámetros
            comando.Parameters.AddWithValue("@FechaAntes", fechaAntes);
            comando.Parameters.AddWithValue("@FechaDespues", fechaDespues);

            try
            {
                MySqlDataReader reader = comando.ExecuteReader();

                // Limpiar filas existentes en el DataGridView
                DTGC.Rows.Clear();

                int contadorSalarios = 0;
                // Leer los datos y agregarlos al DataGridView
                while (reader.Read())
                {
                    // Agregar una nueva fila con los datos del lector
                    DTGC.Rows.Add(reader["Nombre"].ToString(), reader["Fecha"].ToString(), reader["SalarioBase"].ToString(), reader["Comisión"].ToString(), reader["ComisiónXPedido"].ToString(), reader["SalarioTotal"].ToString());
                    contadorSalarios++;
                }
             ;

                reader.Close(); // Cerrar el lector después de usarlo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.Message);
            }
        }

        private void Consultorio_SalariosGeneral_Load(object sender, EventArgs e)
        {
            conexion.Open();

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }
    }
}
