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
    
    public partial class Cliente : Form
    {
        private int filaActual = 0;
        MySqlConnection conexion;
        public Cliente()
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

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtCorreo.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            conexion.Open();
            actualizarDGV();
        }

        public void actualizarDGV()
        {
            string consulta = "SELECT * FROM cliente";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();

            DTGC.Rows.Clear();

            while (lector.Read())
            {
                DTGC.Rows.Add(lector[0], lector[1], lector[2], lector[3]);
            }

            lector.Close();

        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO cliente (Nombre, Telefono, Correo) VALUES ('" + txtNombre.Text + "', '" +
             txtTelefono.Text + "', '" +
             txtCorreo.Text + "')";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            actualizarDGV();
          
            txtNombre.Enabled = false;
            
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }

        private void cmdPrimero_Click(object sender, EventArgs e)
        {
            if (DTGC.Rows.Count > 0)
            {
                filaActual = 0;
                SeleccionarFilaActual();
            }
            MostrarValoresFilaSeleccionada();
        }

        private void SeleccionarFilaActual()
        {
            // Seleccionar la fila actual y deseleccionar otras filas
            DTGC.ClearSelection();
            DTGC.Rows[filaActual].Selected = true;
            DTGC.CurrentCell = DTGC.Rows[filaActual].Cells[0]; // Seleccióna la primera celda de la fila
        }
        private void MostrarValoresFilaSeleccionada()
        {
            if (DTGC.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = DTGC.CurrentRow;

                // Mostrar los valores de la fila seleccionada en los TextBox correspondientes
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = filaSeleccionada.Cells["Correo"].Value.ToString();

            }
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            if (filaActual < DTGC.Rows.Count - 1)
            {
                filaActual++;
                SeleccionarFilaActual();
            }
            MostrarValoresFilaSeleccionada();
        }

        private void cmdUltimo_Click(object sender, EventArgs e)
        {
            if (DTGC.Rows.Count > 0)
            {
                filaActual = DTGC.Rows.Count - 1;
                SeleccionarFilaActual();
            }
            MostrarValoresFilaSeleccionada();
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            if (filaActual > 0)
            {
                filaActual--;
                SeleccionarFilaActual();
            }
            MostrarValoresFilaSeleccionada();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string actualizar = "UPDATE cliente SET ";
            actualizar += "Telefono = '" + txtTelefono.Text + "', ";
            actualizar += "Correo = '" + txtCorreo.Text + "' ";
            actualizar += "WHERE Nombre = '" + txtNombre.Text + "'";


            MySqlCommand comando = new MySqlCommand(actualizar, conexion);
            comando.ExecuteNonQuery();
            actualizarDGV();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM cliente";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();

            DTGC.Rows.Clear();

            while (lector.Read())
            {
                DTGC.Rows.Add(lector[0], lector[1], lector[2], lector[3]);
            }

            lector.Close();
        }
    }
}
