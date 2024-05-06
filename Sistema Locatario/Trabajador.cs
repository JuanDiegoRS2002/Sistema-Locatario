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
   
    public partial class Trabajador : Form
    {
        private int filaActual = 0;
        MySqlConnection conexion;
        public Trabajador()
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

        private void Trabajador_Load(object sender, EventArgs e)
        {
            conexion.Open(); 
            actualizarDGV();
        }

        private void MostrarValoresFilaSeleccionada()
        {
            if (DTTJ.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = DTTJ.CurrentRow;

                // Mostrar los valores de la fila seleccionada en los TextBox correspondientes
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
                txtProfesion.Text = filaSeleccionada.Cells["Profesion"].Value.ToString();
                txtEdad.Text = filaSeleccionada.Cells["Edad"].Value.ToString();
                txtAntecedentes.Text = filaSeleccionada.Cells["Antecedentes"].Value.ToString();
            }
        }

        private void SeleccionarFilaActual()
        {
            // Seleccionar la fila actual y deseleccionar otras filas
            DTTJ.ClearSelection();
            DTTJ.Rows[filaActual].Selected = true;
            DTTJ.CurrentCell = DTTJ.Rows[filaActual].Cells[0]; // Seleccióna la primera celda de la fila
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtProfesion.Enabled = true;
            txtEdad.Enabled = true;
            txtAntecedentes.Enabled = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtProfesion.Text = "";
            txtEdad.Text = "";
            txtProfesion.Text = "";
            txtAntecedentes.Text = "";
        }
        public void actualizarDGV()
        {
            string consulta = "SELECT * FROM trabajador";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            DTTJ.Rows.Clear();

            while (lector.Read())
            {
                DTTJ.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5]);
            }

            lector.Close();

        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO trabajador (Nombre, Telefono, Profesion, Edad, Antecedentes) VALUES ('"+ txtNombre.Text + "', '" +
                txtTelefono.Text + "', '" +
                txtProfesion.Text + "', '" +
                txtEdad.Text + "', '" +
                txtAntecedentes.Text + "')";
            MessageBox.Show(query);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            actualizarDGV();
            txtNombre.Enabled = false;
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtProfesion.Text = "";
            txtEdad.Text = "";
            txtProfesion.Text = "";
            txtAntecedentes.Text = "";
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }

        private void cmdPrimero_Click(object sender, EventArgs e)
        {
            // Seleccionar la primera fila del DataGridView DTTJ
            if (DTTJ.Rows.Count > 0)
            {
                filaActual = 0;
                SeleccionarFilaActual();
            }
            MostrarValoresFilaSeleccionada();
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            if (filaActual < DTTJ.Rows.Count - 1)
            {
                filaActual++;
                SeleccionarFilaActual();
            }
            MostrarValoresFilaSeleccionada(); 
        }

        private void cmdUltimo_Click(object sender, EventArgs e)
        {
            // Seleccionar la última fila del DataGridView DTTJ
            if (DTTJ.Rows.Count > 0)
            {
                filaActual = DTTJ.Rows.Count - 1;
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
            string actualizar = "UPDATE trabajador SET ";
            actualizar += "Telefono = '" + txtTelefono.Text + "', ";
            actualizar += "Edad = '" + txtEdad.Text + "', ";
            actualizar += "Profesion = '" + txtProfesion.Text + "', ";
            actualizar += "Antecedentes = '" + txtAntecedentes.Text + "' ";
            actualizar += "WHERE Nombre = '" + txtNombre.Text + "'";


            MySqlCommand comando = new MySqlCommand(actualizar, conexion);
            comando.ExecuteNonQuery();
            actualizarDGV();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM trabajador";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            DTTJ.Rows.Clear();
           
            while (lector.Read())
            {
                DTTJ.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5]);
            }

            lector.Close();
        }
    }
}
