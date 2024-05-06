using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_Locatario
{
    public partial class Pedidos : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando1 = new MySqlCommand();
        MySqlDataReader lector;
        double subtotal, IVA, total;
        public Pedidos()
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

        private void Pedidos_Load(object sender, EventArgs e)
        {
            conexion.Open();
            LlenarComboHoras();
            comando1 = conexion.CreateCommand();
            comando1.CommandText = "SELECT * FROM cliente";
            lector = comando1.ExecuteReader();
            while (lector.Read())
            {
                CboCliente.Items.Add(lector.GetString(1));
            }
            lector.Close();



            comando1 = conexion.CreateCommand();
            comando1.CommandText = "SELECT * FROM trabajador";
            lector = comando1.ExecuteReader();
            while (lector.Read())
            {
                CboTrabajador.Items.Add(lector.GetString(1));
            }
            lector.Close();


            comando1 = conexion.CreateCommand();
            comando1.CommandText = "SELECT * FROM categorias";
            lector = comando1.ExecuteReader();
            while (lector.Read())
            {
                CboCategoria.Items.Add(lector.GetString(1));
            }
            lector.Close();
            CboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            CboFrutaVerdura.DropDownStyle = ComboBoxStyle.DropDownList;
            CboHora.DropDownStyle = ComboBoxStyle.DropDownList;
            CboTrabajador.DropDownStyle = ComboBoxStyle.DropDownList;

            txtCantidad.Enabled = false;
            txtIdCategoria.Enabled = false;
            txtIdCliente.Enabled = false;
            txtIdFrutaVerdu.Enabled = false;
            txtNombre.Enabled = false;
            txtNombreFV.Enabled = false;
            txtNombreT.Enabled = false;
            txtPrecio.Enabled = false;
            txtProfesion.Enabled = false;
            txtTelefono.Enabled = false;
            txtTotal.Enabled = false;
            CboCategoria.Enabled = false;
            CboCliente.Enabled = false;
            CboFrutaVerdura.Enabled = false;
            CboHora.Enabled = false;
            CboTrabajador.Enabled = false;
            IdTrabajador.Enabled = false;
            txtExistencias.Enabled = false;

            cmdGrabar.Enabled = false;
            cmdInsertar.Enabled = false;




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
        }

        private void CboTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM trabajador WHERE Nombre='" + CboTrabajador.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            lector.Read();
            IdTrabajador.Text = lector[0].ToString();
            txtNombreT.Text = lector[1].ToString();
            txtProfesion.Text = lector[3].ToString();
            lector.Close();
        }

        private void CboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM categorias WHERE Concepto='" + CboCategoria.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            lector.Read();
            txtIdCategoria.Text = lector[0].ToString();
            lector.Close();

            comando1 = conexion.CreateCommand();
            comando1.CommandText = "SELECT * FROM frutasyverduras where IdCategoria ='" + txtIdCategoria.Text + "'";
            lector = comando1.ExecuteReader();
            while (lector.Read())
            {
                CboFrutaVerdura.Items.Add(lector.GetString(2));
            }
            lector.Close();

        }

        private void CboFrutaVerdura_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar que la selección de la ComboBox no contenga símbolos ni letras
            if (!Regex.IsMatch(CboFrutaVerdura.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Ingrese un nombre válido para la fruta o verdura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CboFrutaVerdura.SelectedIndex = -1; // Limpiar la selección de la ComboBox
                return; // Salir del método
            }

            string consulta = "SELECT * FROM frutasyverduras WHERE Nombre='" + CboFrutaVerdura.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                txtIdFrutaVerdu.Text = lector[0].ToString();
                txtNombreFV.Text = lector[2].ToString();
                txtExistencias.Text = lector[5].ToString();
            }
            else
            {
                MessageBox.Show("La fruta o verdura seleccionada no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CboFrutaVerdura.SelectedIndex = -1; // Limpiar la selección de la ComboBox
            }
            lector.Close();
        }

        private void CBMenudeo_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMenudeo.Checked) // Si el CheckBox está marcado
            {
                // Verificar que el nombre de la fruta o verdura esté seleccionado
                if (string.IsNullOrEmpty(txtNombreFV.Text))
                {
                    MessageBox.Show("Seleccione una fruta o verdura antes de activar el modo menudeo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CBMenudeo.Checked = false; // Desmarcar el CheckBox
                    return; // Salir del método
                }

                // Consultar el precio de menudeo de la fruta o verdura seleccionada
                string consulta = "SELECT PrecioMenudeo FROM frutasyverduras WHERE Nombre='" + txtNombreFV.Text + "'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) // Si se encuentra la fruta o verdura en la base de datos
                {
                    txtPrecio.Text = lector[0].ToString(); // Mostrar el precio en el cuadro de texto
                }
                else // Si no se encuentra la fruta o verdura en la base de datos
                {
                    MessageBox.Show("La fruta o verdura seleccionada no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CBMenudeo.Checked = false; // Desmarcar el CheckBox
                }

                lector.Close(); // Cerrar el lector de datos
            }
            else // Si el CheckBox está desmarcado
            {
                txtPrecio.Text = ""; // Limpiar el cuadro de texto
            }
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

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCliente.Text) ||
                string.IsNullOrEmpty(IdTrabajador.Text) ||
                string.IsNullOrEmpty(CboHora.Text) ||
                string.IsNullOrEmpty(txtTotal.Text))
            {
                MessageBox.Show("Todos los campos marcados con * son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin ejecutar la consulta SQL
            }

            // Validar que la hora sea un valor numérico válido
            DateTime hora;
            if (!DateTime.TryParseExact(CboHora.Text, "H:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out hora))
            {
                MessageBox.Show("Por favor ingrese una hora válida en formato HH:mm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin ejecutar la consulta SQL
            }

            string fecha = DTF.Value.Year + "-" + DTF.Value.Month + "-" + DTF.Value.Day;

            string query = "INSERT INTO pedido (IdCliente, IdTrabajador, Fecha, Hora, Total, Statu, StatuT) VALUES ('" +
                txtIdCliente.Text + "', '" +
                IdTrabajador.Text + "', '" +
                fecha + "', '" +
                CboHora.Text + "', '" +
                txtTotal.Text + "', 'r', 'NoC')";

            MessageBox.Show(query);

            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            int dgvRows = DTGFrutas.Rows.Count; // Total de las filas en el DataGridView
            for (int i = 0; i < dgvRows - 1; i++)
            {
                string nombreProducto = DTGFrutas.Rows[i].Cells["FrutaOverdura"].Value.ToString(); // Nombre del producto desde el DataGridView
                int cantidadADecrementar = Convert.ToInt32(DTGFrutas.Rows[i].Cells["Cantidad"].Value); // Cantidad a decrementar desde el DataGridView

                // Consultar existencias actuales del producto
                string queryExistencias = "SELECT ExistenciasKG FROM frutasyverduras WHERE Nombre = @NombreProducto";
                MySqlCommand comandoExistencias = new MySqlCommand(queryExistencias, conexion);
                comandoExistencias.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                int existenciaActual = Convert.ToInt32(comandoExistencias.ExecuteScalar());

                // Decrementar existencias
                int nuevaExistencia = existenciaActual - cantidadADecrementar;

                // Actualizar existencias en la tabla frutasyverduras
                string queryUpdate = "UPDATE frutasyverduras SET ExistenciasKG = @NuevaExistencia WHERE Nombre = @NombreProducto";
                MySqlCommand comandoUpdate = new MySqlCommand(queryUpdate, conexion);
                comandoUpdate.Parameters.AddWithValue("@NuevaExistencia", nuevaExistencia);
                comandoUpdate.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                comandoUpdate.ExecuteNonQuery();
            }

            for (int i = 0; i < dgvRows - 1; i++)
            {
                int c0 = Convert.ToInt32(IdPedido.Text);
                int c1 = Convert.ToInt32(DTGFrutas.Rows[i].Cells[0].Value);
                float c2 = Convert.ToInt32(DTGFrutas.Rows[i].Cells[2].Value);
                double c3 = Convert.ToInt64(DTGFrutas.Rows[i].Cells[3].Value);
                MessageBox.Show(c0 + ", " + c1 + " ," + c2 + ", " + c3);
                query = "INSERT INTO detpedido Values(" +
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
            }
            MessageBox.Show(query);
        }


        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            MySqlCommand comando1 = new MySqlCommand("SELECT COUNT(*) FROM pedido", conexion);
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
                txtCantidad.Text = "";
                txtIdCategoria.Text = "";
                txtIdCliente.Text = "";
                txtIdFrutaVerdu.Text = "";
                txtNombre.Text = "";
                txtNombreFV.Text = "";
                txtNombreT.Text = "";
                txtPrecio.Text = "";
                txtProfesion.Text = "";
            
                txtTelefono.Text = "";
                txtTotal.Text = "";
                CboCategoria.Text = "";
                CboCliente.Text = "";
                CboFrutaVerdura.Text = "";
                CboHora.Text = "";
                CboTrabajador.Text = "";
                IdTrabajador.Text = "";
                txtExistencias.Text = "";
                DTGFrutas.Rows.Clear();

                txtCantidad.Enabled = true;
                CboCategoria.Enabled = true;
                CboCliente.Enabled = true;
                CboFrutaVerdura.Enabled = true;
                CboHora.Enabled = true;
                CboTrabajador.Enabled = true;



              
                cmdInsertar.Enabled = true;





            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }

        private void IdPedido_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtExistencias_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCantidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CBMayoreo_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMayoreo.Checked) // Si el CheckBox está marcado
            {
                // Verificar que el nombre de la fruta o verdura esté seleccionado
                if (string.IsNullOrEmpty(txtNombreFV.Text))
                {
                    MessageBox.Show("Seleccione una fruta o verdura antes de activar el modo mayoreo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CBMayoreo.Checked = false; // Desmarcar el CheckBox
                    return; // Salir del método
                }

                // Consultar el precio de mayoreo de la fruta o verdura seleccionada
                string consulta = "SELECT PrecioMayoreo FROM frutasyverduras WHERE Nombre='" + txtNombreFV.Text + "'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) // Si se encuentra la fruta o verdura en la base de datos
                {
                    txtPrecio.Text = lector[0].ToString(); // Mostrar el precio en el cuadro de texto
                }
                else // Si no se encuentra la fruta o verdura en la base de datos
                {
                    MessageBox.Show("La fruta o verdura seleccionada no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CBMayoreo.Checked = false; // Desmarcar el CheckBox
                }

                lector.Close(); // Cerrar el lector de datos
            }
            else // Si el CheckBox está desmarcado
            {
                txtPrecio.Text = ""; // Limpiar el cuadro de texto
            }
        }


        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdFrutaVerdu.Text) ||
                string.IsNullOrEmpty(CboFrutaVerdura.Text) ||
                string.IsNullOrEmpty(txtPrecio.Text) ||
                string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Tiene que tener algo escrito en los campos de Frutas y Verduras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin agregar la fila al DataGridView
            }

            // Verificar que los campos de cantidad y precio sean números válidos
            int cantidad, idFruta;
            double precio;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0 ||
                !int.TryParse(txtIdFrutaVerdu.Text, out idFruta) || idFruta <= 0 ||
                !double.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos en los campos de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin agregar la fila al DataGridView
            }

            // Verificar que el nombre de la fruta o verdura no contenga números agregados o caracteres no deseados
            if (Regex.IsMatch(CboFrutaVerdura.Text, @"\d"))
            {
                MessageBox.Show("El nombre de la fruta o verdura no debe contener números agregados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin agregar la fila al DataGridView
            }

            // Calcular subtotal y actualizar total
            double subtotal = cantidad * precio;
            total += subtotal; // Sumar el subtotal al total existente
            txtTotal.Text = total.ToString();

            // Agregar la nueva fila al DataGridView
            DTGFrutas.Rows.Add(idFruta, CboFrutaVerdura.Text, precio, cantidad, subtotal, txtTotal.Text);
            cmdGrabar.Enabled = true;
        }
    }
 }


