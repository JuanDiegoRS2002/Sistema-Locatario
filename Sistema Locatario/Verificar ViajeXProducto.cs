using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Locatario
{
    public partial class Verificar_ViajeXProducto : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Verificar_ViajeXProducto()
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

       

        private void Verificar_ViajeXProducto_Load(object sender, EventArgs e)
        {
            conexion.Open();
            

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM trabajador WHERE Profesion='Chofer'";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                CboTrabajador.Items.Add(lector.GetString(1));
            }
            lector.Close();
            CboTrabajador.DropDownStyle = ComboBoxStyle.DropDownList;
            CboViajes.DropDownStyle = ComboBoxStyle.DropDownList;
            CboFrutaVerdura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmdVerificar.Enabled = false;

        }

        private void CboTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM trabajador WHERE Nombre='" + CboTrabajador.Text + "' AND Profesion='Chofer'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            lector.Read();
            txtIdTrabajador.Text = lector[0].ToString();
            lector.Close();

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM viajesxproducto where IdTrabajador ='" + txtIdTrabajador.Text + "'";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                CboViajes.Items.Add(lector.GetInt32(0).ToString());
            }
            lector.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string consultaDetallePedidos = "SELECT F.IdFrutaVerdu As Fruta, F.Nombre As NombreFrutas, Dt.Cantidad, Dt.CantidadVerificada " +
                                "FROM detviaje AS Dt " +
                                "INNER JOIN frutasyverduras AS F ON F.IdFrutaVerdu = Dt.IdFrutaVerdu " +
                                "WHERE Dt.IdViaje = @Pedido";

            DTGFrutas.Rows.Clear();
            comando = new MySqlCommand(consultaDetallePedidos, conexion);
            comando.Parameters.AddWithValue("@Pedido", CboViajes.Text);

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
               
                DTGFrutas.Rows.Add(
                     lector["Fruta"].ToString(),
                     lector["NombreFrutas"].ToString(),
                     lector["Cantidad"].ToString(),
                     lector["CantidadVerificada"].ToString()
                    
                    
                );

                
                string nombreFruta = lector["NombreFrutas"].ToString();
                if (!CboFrutaVerdura.Items.Contains(nombreFruta))
                {
                    CboFrutaVerdura.Items.Add(nombreFruta);
                }
                
            }

            lector.Close();
            cmdVerificar.Enabled = true;
        }
        

        private void CboFrutaVerdura_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string consulta = "SELECT * FROM frutasyverduras WHERE Nombre='" + CboFrutaVerdura.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            lector.Read();
            txtIdFrutaVerdu.Text = lector[0].ToString();
            txtNombreFV.Text = lector[2].ToString();
            txtExistencias.Text = lector[5].ToString();

            lector.Close();
        }

        private void cmdVerificar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreFV.Text; // Nombre del producto desde el DataGridView
            int cantidadIncrementar = Convert.ToInt32(txtCantidad.Text);
            int viaje = Convert.ToInt32(CboViajes.Text);


            // Consultar existencias actuales del producto
            string queryExistencias = "SELECT ExistenciasKG FROM frutasyverduras WHERE Nombre = @NombreProducto";
            MySqlCommand comandoExistencias = new MySqlCommand(queryExistencias, conexion);
            comandoExistencias.Parameters.AddWithValue("@NombreProducto", nombreProducto);
            int existenciaActual = Convert.ToInt32(comandoExistencias.ExecuteScalar());

            int nuevaExistencia = existenciaActual + cantidadIncrementar;

            string queryUpdate = "UPDATE frutasyverduras SET ExistenciasKG = @NuevaExistencia WHERE Nombre = @NombreProducto";
            MySqlCommand comandoUpdate = new MySqlCommand(queryUpdate, conexion);
            comandoUpdate.Parameters.AddWithValue("@NuevaExistencia", nuevaExistencia);
            comandoUpdate.Parameters.AddWithValue("@NombreProducto", nombreProducto);
            comandoUpdate.ExecuteNonQuery();

          

            string queryUpdateDt = "UPDATE detviaje SET CantidadVerificada = @CantidadVerificada WHERE IdViaje = @Viaje AND IdFrutaVerdu = @FrutaVerdura";
            MySqlCommand comandoUpdateDt = new MySqlCommand(queryUpdateDt, conexion);
            comandoUpdateDt.Parameters.AddWithValue("@CantidadVerificada", txtCantidad.Text);
            comandoUpdateDt.Parameters.AddWithValue("@Viaje", CboViajes.Text); // Valor del IdViaje seleccionado
            comandoUpdateDt.Parameters.AddWithValue("@FrutaVerdura", txtIdFrutaVerdu.Text); // Valor del IdFrutaVerdura específico
            comandoUpdateDt.ExecuteNonQuery();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }

        private void CboViajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
