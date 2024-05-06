using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Locatario
{
    public partial class FrutasVerduras : Form
    {
        private int filaActual = 0;
        
        MySqlConnection conexion;
        MySqlCommand comando1 = new MySqlCommand();
        MySqlDataReader lector;

        public FrutasVerduras()
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

        private void FrutasVerduras_Load(object sender, EventArgs e)
        {
            conexion.Open();
            actualizarDGV();
            
            comando1 = conexion.CreateCommand();
            comando1.CommandText = "Select * from categorias";
            lector = comando1.ExecuteReader();
            while (lector.Read())
            {

                CboCategoria.Items.Add(lector[1]);
            }

            lector.Close();
        }

        private void actualizarDGV()
        {
            string consulta = "SELECT F.IdFrutaVerdu, C.Concepto, F.Nombre, F.PrecioMayoreo, F.PrecioMenudeo, F.ExistenciasKG, F.`Imagen Url` From frutasyverduras As F Inner Join categorias As C on F.IdCategoria = C.IdCategoria";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();

            DTGF.Rows.Clear();

            while (lector.Read())
            {
                // Obtener la URL de la imagen
                string urlImagen = lector["Imagen Url"].ToString();

                // Crear una nueva fila
                DataGridViewRow fila = new DataGridViewRow();

                // Añadir las celdas a la fila
                fila.CreateCells(DTGF);
                fila.Cells[0].Value = lector[0];
                fila.Cells[1].Value = lector[1];
                fila.Cells[2].Value = lector[2];
                fila.Cells[3].Value = lector[3];
                fila.Cells[4].Value = lector[4];
                fila.Cells[5].Value = lector[5];

                // Verificar si hay una URL válida para la imagen
                if (!string.IsNullOrEmpty(urlImagen))
                {
                    // Intentar cargar la imagen desde la URL
                    try
                    {
                        Image imagen = Image.FromFile(urlImagen);
                        // Mostrar la imagen en la fila del DataGridView
                        fila.Cells[6].Value = imagen;
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error al cargar la imagen
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                    }
                }

                // Agregar la fila al DataGridView
                DTGF.Rows.Add(fila);
            }

            lector.Close();
        }


        private void cmdNuevo_Click(object sender, EventArgs e)
        {

            txtNombre.Enabled = true;
            txtPrecioMayoreo.Enabled = true;
            txtPrecioMenudeo.Enabled = true;
            txtExistenciasKG.Enabled = true;
            txtIdCategoria.Text = "";
            txtNombre.Text = "";
            txtPrecioMayoreo.Text = "";
            txtPrecioMenudeo.Text = "";
            txtExistenciasKG.Text = "";

        }

        

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO frutasyverduras (IdCategoria, Nombre, PrecioMayoreo, PrecioMenudeo, ExistenciasKG, `Imagen Url`) VALUES ('" +
    txtIdCategoria.Text + "', '" +
    txtNombre.Text + "', '" +
    txtPrecioMayoreo.Text + "', '" +
    txtPrecioMenudeo.Text + "', '" +
    txtExistenciasKG.Text + "', '" +
    txtImagenUrl + "')";


            MessageBox.Show(query);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            actualizarDGV();

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string actualizar = "UPDATE frutasyverduras SET ";
            actualizar += "`Nombre` = '" + txtNombre.Text + "', ";
            actualizar += "PrecioMayoreo = '" + txtPrecioMayoreo.Text + "', ";
            actualizar += "PrecioMenudeo = '" + txtPrecioMenudeo.Text + "', ";
            actualizar += "`ExistenciasKG` = '" + txtExistenciasKG.Text + "' ";
            actualizar += "WHERE `Nombre` = '" + txtNombre.Text + "'";

            MySqlCommand comando = new MySqlCommand(actualizar, conexion);
            comando.ExecuteNonQuery();
            actualizarDGV();
        }


        private void cmdPrimero_Click(object sender, EventArgs e)
        {
            if (DTGF.Rows.Count > 0)
            {
                filaActual = 0;
                SeleccionarFilaActual();
            }
            MostrarValoresFilaSeleccionada();
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            if (filaActual < DTGF.Rows.Count - 1)
            {
                filaActual++;
                SeleccionarFilaActual();
            }
            MostrarValoresFilaSeleccionada();
        }

        private void cmdUltimo_Click(object sender, EventArgs e)
        {
            if (DTGF.Rows.Count > 0)
            {
                filaActual = DTGF.Rows.Count - 1;
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

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }
        private void SeleccionarFilaActual()
        {
            // Seleccionar la fila actual y deseleccionar otras filas
            DTGF.ClearSelection();
            DTGF.Rows[filaActual].Selected = true;
            DTGF.CurrentCell = DTGF.Rows[filaActual].Cells[0]; // Seleccióna la primera celda de la fila
        }

        private void CboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM categorias WHERE Concepto='" + CboCategoria.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            lector.Read();
            txtIdCategoria.Text = lector[0].ToString();
            lector.Close();
        

        }
        private void MostrarValoresFilaSeleccionada()
        {
            if (DTGF.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = DTGF.CurrentRow;

                // Mostrar los valores de la fila seleccionada en los TextBox correspondientes
                txtIdCategoria.Text = filaSeleccionada.Cells["Concepto"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtPrecioMayoreo.Text = filaSeleccionada.Cells["PrecioMayoreo"].Value.ToString();
                txtPrecioMenudeo.Text = filaSeleccionada.Cells["PrecioMenudeo"].Value.ToString();
                txtExistenciasKG.Text = filaSeleccionada.Cells["ExistenciasKG"].Value.ToString();
                txtImagenUrl.Text = filaSeleccionada.Cells["ImagenUrl"].Value.ToString();

            }
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM frutasyverduras";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();

            DTGF.Rows.Clear();

            while (lector.Read())
            {
                DTGF.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6]);
            }

            lector.Close();

        }
    }
}
