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
    public partial class Consultar_FrutasyVerduras : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando1 = new MySqlCommand();
        MySqlDataReader lector;
        public Consultar_FrutasyVerduras()
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

        private void DTGF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string consulta = "SELECT * FROM frutasyverduras";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();

            DTGF.Rows.Clear();

            while (lector.Read())
            {
                DTGF.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5]);
            }

            lector.Close();
        }
        public void actualizarDGV()
        {
            

        }
    }
}
