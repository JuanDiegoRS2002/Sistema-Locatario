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
using Mysqlx.Cursor;


namespace Sistema_Locatario
{


    public partial class Categorias : Form
    {
        MySqlConnection conexion;

        public Categorias()
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

        private void Categorias_Load(object sender, EventArgs e)
        {

            conexion.Open();
            actualizarDGV();

        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtConcepto.Enabled = true;
            txtConcepto.Text= "";
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO categorias (Concepto) VALUES ('" + txtConcepto.Text + "')";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            actualizarDGV();
            txtConcepto.Enabled = false;
        }

        public void actualizarDGV()
        {
            string consulta = "SELECT * FROM categorias";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();

            DTG.Rows.Clear(); 

            while (lector.Read())
            {
                DTG.Rows.Add(lector[0], lector[1]);
            }

            lector.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Close();
            this.Close();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM categorias";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();

            DTG.Rows.Clear();

            while (lector.Read())
            {
                DTG.Rows.Add(lector[0], lector[1]);
            }

            lector.Close();

        }
    }
}
