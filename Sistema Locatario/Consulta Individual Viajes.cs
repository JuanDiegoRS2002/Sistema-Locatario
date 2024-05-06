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
    public partial class Consulta_Individual_Viajes : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Consulta_Individual_Viajes()
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

        private void Consulta_Individual_Viajes_Load(object sender, EventArgs e)
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
        }

        private void CboTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM trabajador WHERE Nombre='" + CboTrabajador.Text + "' AND Profesion='Chofer'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                txtIdTrabajador.Text = lector[0].ToString();
                txtNombre.Text = lector[1].ToString();
                txtProfesion.Text = lector[3].ToString();

            }
            else
            {
                // Manejar el caso en el que no se encontraron trabajadores con la profesión "Choferes"
            }
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
          

            string consulta = "SELECT Ciudad, Fecha, Hora, Prestamo " +
                  "FROM viajesxproducto AS VP " +
                  "JOIN trabajador AS T ON VP.IdTrabajador = T.IdTrabajador " +
                  "WHERE T.Nombre = @nombreTrabajador " +
                  "AND VP.IdViaje = @IdViaje";

       
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@nombreTrabajador", CboTrabajador.Text);
            comando.Parameters.AddWithValue("@idViaje", CboViajes.Text);
            MySqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                // Agregar cada fila al DataGridView
                DTGBusqueda.Rows.Add(
                    lector["Ciudad"].ToString(),
                    lector["Fecha"].ToString(),
                    lector["Hora"].ToString(),
                    lector["Prestamo"].ToString()


                );
            }
            lector.Close();

            string consulta1 = "SELECT DV.IdFrutaVerdu, F.Nombre AS NombreFruta, DV.Cantidad, DV.CantidadVerificada " +
        "FROM detviaje AS DV " +
      "JOIN frutasyverduras AS F ON DV.IdFrutaVerdu = F.IdFrutaVerdu " +
      "WHERE DV.IdViaje = @idViaje";

            MySqlCommand comandoDetalle = new MySqlCommand(consulta1, conexion);  // Utiliza consulta1 en lugar de consulta
            comandoDetalle.Parameters.AddWithValue("@idViaje", CboViajes.Text); // Aquí debes proporcionar el IdTrabajador seleccionado
            MySqlDataReader lectorDetalle = comandoDetalle.ExecuteReader();

            while (lectorDetalle.Read())
            {
                // Agregar cada fila al DataGridView "DTGP"
                DTGP.Rows.Add(
                    lectorDetalle["IdFrutaVerdu"].ToString(),
                    lectorDetalle["NombreFruta"].ToString(),
                    lectorDetalle["Cantidad"].ToString(),
                    lectorDetalle["CantidadVerificada"].ToString()
                );
            }

            lectorDetalle.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }

        private void CboViajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
