using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Locatario
{
    public partial class ViajesXProducto_Registrar : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public ViajesXProducto_Registrar()
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

        private void ViajesXProducto_Registrar_Load(object sender, EventArgs e)
        {
            conexion.Open();
            LlenarComboHoras();

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM trabajador WHERE Profesion='Chofer'";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                CboTrabajador.Items.Add(lector.GetString(1));
            }
            lector.Close();

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM categorias";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                CboCategoria.Items.Add(lector.GetString(1));
            }
            lector.Close();

            CboTrabajador.DropDownStyle = ComboBoxStyle.DropDownList;
            CboHora.DropDownStyle = ComboBoxStyle.DropDownList;
            CboFrutaVerdura.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CboHora.Enabled = false;
            CboTrabajador.Enabled = false;
            txtCiudad.Enabled = false;
            txtPrestamo.Enabled = false;
            txtCantidad.Enabled = false;
            CboCategoria.Enabled = false;
            CboFrutaVerdura.Enabled = false;
            cmdGrabar.Enabled = false;
            cmdInsertar.Enabled = false;

        }

        private void LlenarComboHoras()
        {
            for (int i = 9; i < 15; i++) // Horas de la mañana
            {
                CboHora.Items.Add(i.ToString() + ":00");
                CboHora.Items.Add(i.ToString() + ":30");
            }

            for (int i = 16; i < 20; i++) // Horas de la tarde
            {
                CboHora.Items.Add(i.ToString() + ":00");
                CboHora.Items.Add(i.ToString() + ":30");
            }
        }

        private void CboHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            string horaSeleccionada = CboHora.SelectedItem.ToString();
        }

        private void CboTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM trabajador WHERE Nombre='" + CboTrabajador.Text + "' AND Profesion='Chofer'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                txtNumero.Text = lector[0].ToString();
                txtNombreT.Text = lector[1].ToString();
                txtProfesion.Text = lector[3].ToString();
            }
            else
            {
                // Manejar el caso en el que no se encontraron trabajadores con la profesión "Choferes"
            }
            lector.Close();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            MySqlCommand comando1 = new MySqlCommand("SELECT COUNT(*) FROM viajesxproducto", conexion);
            object result = comando1.ExecuteScalar();
            if (result != null)
            {
                int n;
                if (int.TryParse(result.ToString(), out n))
                {
                    n++; // Incrementa en 1
                    IdPedido.Text = n.ToString();
                }
                else
                {

                }

                CboHora.Enabled = true;
                CboTrabajador.Enabled = true;
                txtCiudad.Enabled = true;
                txtPrestamo.Enabled = true;
                txtCantidad.Enabled = true;
                CboCategoria.Enabled = true;
                CboFrutaVerdura.Enabled = true;


                CboHora.Text = "";
                CboTrabajador.Text = "";
                txtCiudad.Text = "";
                txtNombreT.Text = "";
                txtPrestamo.Text = "";
                txtProfesion.Text = "";
                txtCantidad.Text = "";
                txtExistencias.Text = "";
                txtIdCategoria.Text = "";
                txtIdFrutaVerdu.Text = "";
                txtNombreFV.Text = "";
                txtNumero.Text = "";
                DTGFrutas.Rows.Clear();
                cmdInsertar.Enabled = true;



            }
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos obligatorios estén llenos
            if (string.IsNullOrEmpty(txtNumero.Text) ||
                string.IsNullOrEmpty(CboHora.Text) ||
                string.IsNullOrEmpty(txtCiudad.Text) ||
                string.IsNullOrEmpty(txtPrestamo.Text) ||
                DTGFrutas.Rows.Count <= 1) // Si el DataGridView tiene solo la fila de encabezado, no hay datos para grabar
            {
                MessageBox.Show("Todos los campos marcados con * son obligatorios y debe agregar al menos un producto al viaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin ejecutar la consulta SQL
            }

            // Verificar que los valores ingresados sean válidos
            int numeroTrabajador, prestamo;
            if (!int.TryParse(txtNumero.Text, out numeroTrabajador) || numeroTrabajador <= 0 ||
                !int.TryParse(txtPrestamo.Text, out prestamo) || prestamo <= 0)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos en los campos de número de trabajador y préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin ejecutar la consulta SQL
            }

            // Verificar que las ComboBox no contengan más de un número, letra o símbolo
            DateTime hora;
            if (!DateTime.TryParseExact(CboHora.Text, "H:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out hora))
            {
                MessageBox.Show("Por favor ingrese una hora válida en formato HH:mm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin ejecutar la consulta SQL
            }

            // Obtener la fecha en el formato correcto
            string fecha = DTF.Value.ToString("yyyy-MM-dd");

            // Construir la consulta de inserción
            string query = "INSERT INTO viajesxproducto (IdTrabajador, Fecha, Hora, Ciudad, Prestamo) VALUES ('" +
                txtNumero.Text + "', '" +
                fecha + "', '" +
                CboHora.Text + "', '" +
                txtCiudad.Text + "', '" +
                txtPrestamo.Text + "')";

            // Mostrar la consulta en un mensaje (para verificar)
            MessageBox.Show(query);

            // Ejecutar la consulta de inserción
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            // Iterar sobre las filas del DataGridView para insertar los detalles del viaje
            for (int i = 0; i < DTGFrutas.Rows.Count - 1; i++)
            {
                int c0 = Convert.ToInt32(IdPedido.Text);
                int c1 = Convert.ToInt32(DTGFrutas.Rows[i].Cells[0].Value);
                int c2 =
               Convert.ToInt32(DTGFrutas.Rows[i].Cells[2].Value);
                int c3 = 0;
                MessageBox.Show(c0 + ", " + c1 + " ," + c2 + ", " + c3);
                query = "INSERT INTO detviaje Values(" +
                c0 +
               "," +
               c1 +
              "," +
               c2 +
               "," +
               c3 +
               ")";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            
            MessageBox.Show(query);
        }

            MessageBox.Show("El registro se ha guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }

        private void CboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCategoria.SelectedItem != null)
            {
                string consulta = "SELECT * FROM categorias WHERE Concepto='" + CboCategoria.Text + "'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    txtIdCategoria.Text = lector[0].ToString();
                    lector.Close();

                    CboFrutaVerdura.Items.Clear();
                    CboFrutaVerdura.Text = "";
                    comando = conexion.CreateCommand();
                    comando.CommandText = "SELECT * FROM frutasyverduras where IdCategoria ='" + txtIdCategoria.Text + "'";
                    lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        CboFrutaVerdura.Items.Add(lector.GetString(2));
                    }
                    lector.Close();
                }
                else
                {
                    lector.Close();
                    MessageBox.Show("La categoría seleccionada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdFrutaVerdu.Text) ||
                string.IsNullOrEmpty(CboFrutaVerdura.Text) ||
                string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin agregar la fila al DataGridView
            }

            // Verificar que el ID de la fruta y la cantidad sean números válidos
            int idFruta, cantidad;
            if (!int.TryParse(txtIdFrutaVerdu.Text, out idFruta) || idFruta <= 0 ||
                !int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos en los campos de ID de fruta y cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin agregar la fila al DataGridView
            }

            // Verificar que la ComboBox CboFrutaVerdura no contenga números o símbolos extraños
            if (CboFrutaVerdura.Text.Any(char.IsDigit) || CboFrutaVerdura.Text.Any(char.IsSymbol))
            {
                MessageBox.Show("La ComboBox 'FrutaVerdura' no puede contener números o símbolos extraños.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin agregar la fila al DataGridView
            }

            // Agregar la nueva fila al DataGridView
            DTGFrutas.Rows.Add(idFruta, CboFrutaVerdura.Text, cantidad);
            cmdGrabar.Enabled = true;
        }


        private void CboFrutaVerdura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboFrutaVerdura.SelectedItem != null)
            {
                string consulta = "SELECT * FROM frutasyverduras WHERE Nombre='" + CboFrutaVerdura.Text + "'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    txtIdFrutaVerdu.Text = lector[0].ToString();
                    txtNombreFV.Text = lector[2].ToString();
                    txtExistencias.Text = lector[5].ToString();
                    lector.Close();
                }
                else
                {
                    lector.Close();
                    MessageBox.Show("La fruta o verdura seleccionada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fruta o verdura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
