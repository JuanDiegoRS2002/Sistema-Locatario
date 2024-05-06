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
    public partial class Consultar_Salarios : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;


        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT Fecha, FechaAntes, FechaDespues, SalarioBase, Comision, ComisionXPedido FROM salarios WHERE IdTrabajador = " + txtNumero.Text;
            MySqlCommand comando = new MySqlCommand(query, conexion);

            try
            {
                MySqlDataReader reader = comando.ExecuteReader();
                DTGTrabajador.Rows.Clear();
                
                while (reader.Read())
                {
                    DTGTrabajador.Rows.Add(reader["Fecha"], reader["SalarioBase"], reader["Comision"], reader["ComisionXPedido"]);
                    txtFechaInicio.Text = reader["FechaAntes"].ToString();
                    txtFechaFinal.Text = reader["FechaDespues"].ToString();
                }

                // Cerrar el lector después de usarlo
                reader.Close();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la ejecución de la consulta
                MessageBox.Show("Error al buscar datos: " + ex.Message);
            }
        }

        public Consultar_Salarios()
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

        private void Consultar_Salarios_Load(object sender, EventArgs e)
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

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }
    }
}
