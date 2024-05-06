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
using Microsoft.Reporting.WinForms;
using System.Configuration;
using System.Data.SqlClient;

namespace Sistema_Locatario
{
    public partial class REPORTES : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        string fechahoy = DateTime.Now.ToString("yyyy-MM-dd");
        public REPORTES()
        {
            string servidor = "localhost";
            string bd = "sistemalocatario";
            string usuario = "root";
            string password = "";
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            conexion = new MySqlConnection(cadenaConexion);
            InitializeComponent();
        }

        private void REPORTES_Load(object sender, EventArgs e)
        {


            conexion.Open();
            comando = conexion.CreateCommand();
            this.reportViewer1.RefreshReport();

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM categorias";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                comboBoxConcepto.Items.Add(lector.GetString(1));
            }
            lector.Close();
            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM trabajador";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                CboTrabajador.Items.Add(lector.GetString(3));
            }
            lector.Close();

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM trabajador";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                CboTrabajador1.Items.Add(lector.GetString(1));
            }
            lector.Close();

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM cliente";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboCliente.Items.Add(lector.GetString(1));
            }
            lector.Close();

         

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM trabajador";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                CboTrabajador2.Items.Add(lector.GetString(1));
            }
            lector.Close();

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM trabajador";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboTrabajadoresChoferes.Items.Add(lector.GetString(1));
            }
            lector.Close();

            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM frutasyverduras";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboConcepto.Items.Add(lector.GetString(2));
            }
            lector.Close();
        }

       



      

        private void CboTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM trabajador WHERE Profesion='" + CboTrabajador.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            conexion.Close();

        }

        private void cmdBuscarTrabajador_Click(object sender, EventArgs e)
        {
            string profesion = CboTrabajador.Text; // Obtener la profesión seleccionada en el ComboBox

            // Configurar el comando para llamar al procedimiento almacenado
            comando.CommandText = "REPORTE_TRABAJADORES_POR_PROFESION";
            comando.CommandType = CommandType.StoredProcedure;

            // Crear el parámetro Profesion y asignarle el valor de la profesión seleccionada
            MySqlParameter paramProfesion = new MySqlParameter("@profesion_buscar", MySqlDbType.VarChar, 50);
            paramProfesion.Direction = ParameterDirection.Input;
            paramProfesion.Value = profesion;

            // Limpiar los parámetros anteriores y agregar el nuevo parámetro
            comando.Parameters.Clear();
            comando.Parameters.Add(paramProfesion);

            // Crear un adaptador y llenar el DataSet
            MySqlDataAdapter Adaptador = new MySqlDataAdapter(comando);
            DataSet Data = new DataSet();
            Adaptador.Fill(Data);
            Data.DataSetName = "DataSet1";

            ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Reportes);
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\Lenovo\\Desktop\\Universidad\\Analisis Y Modelado\\Proyecto\\Sistema Locatario\\Sistema Locatario\\Reporte Trabajadores.rdlc";
            reportViewer1.RefreshReport();
            conexion.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        private void comboBoxConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM categorias WHERE Concepto='" + comboBoxConcepto.Text + "'";
        MySqlCommand comando = new MySqlCommand(consulta, conexion);
        conexion.Close();

        }

        private void cmdFrutasVerduras_Click(object sender, EventArgs e)
        {

             string concepto = comboBoxConcepto.Text;

             // Configurar el comando para llamar al procedimiento almacenado
             comando.CommandText = "REPORTEFRUTASYVERDURAS";
             comando.CommandType = CommandType.StoredProcedure;

             // Crear el parámetro Concepto y asignarle el valor del ComboBox
             MySqlParameter paramConcepto = new MySqlParameter("@concepto", MySqlDbType.VarChar, 50);
             paramConcepto.Direction = ParameterDirection.Input;
             paramConcepto.Value = concepto;

             // Limpiar los parámetros anteriores y agregar el nuevo parámetro
             comando.Parameters.Clear();
             comando.Parameters.Add(paramConcepto);

             // Crear un adaptador y llenar el DataSet
             MySqlDataAdapter Adaptador = new MySqlDataAdapter(comando);
             DataSet Data = new DataSet();
             Adaptador.Fill(Data);
             Data.DataSetName = "DataSet1";

             ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);

             reportViewer1.LocalReport.DataSources.Clear();
             reportViewer1.LocalReport.DataSources.Add(Reportes);
             reportViewer1.LocalReport.ReportPath = "C:\\Users\\Lenovo\\Desktop\\Universidad\\Analisis Y Modelado\\Proyecto\\Sistema Locatario\\Sistema Locatario\\REPORTE FRUTASVERDYRAS.rdlc";
             reportViewer1.RefreshReport();
             conexion.Close();
        }

        private void CboTrabajador1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM trabajador WHERE Nombre='" + CboTrabajador1.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            conexion.Close();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM cliente WHERE Nombre='" + cboCliente.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            conexion.Close();

        }

      

        private void CboTrabajador2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM trabajador WHERE Nombre='" + CboTrabajador2.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            conexion.Close();
        }

        private void cboTrabajadoresChoferes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM trabajador WHERE Nombre='" + CboTrabajador.Text + "' AND Profesion='Chofer'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            conexion.Close();
        }

        private void cboConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM frutasyverduras WHERE Nombre='" + cboConcepto.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            conexion.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

     


        private void cmdTotalPedidos_Click(object sender, EventArgs e)
        {
            string fechaInicial = DTFA.Value.ToString("yyyy-MM-dd");
            string fechaFinal = DTFB.Value.ToString("yyyy-MM-dd");
            string nombreTrabajador = CboTrabajador1.Text;

            // Configurar el comando para llamar al procedimiento almacenado
            comando.CommandText = "REPORTE_PEDIDOS_POR_TRABAJADOR_NOMBRE";
            comando.CommandType = CommandType.StoredProcedure;

            // Crear los parámetros de fecha inicial, fecha final y nombre de trabajador
            MySqlParameter paramFechaInicial = new MySqlParameter("@fecha_inicial", MySqlDbType.Date);
            paramFechaInicial.Direction = ParameterDirection.Input;
            paramFechaInicial.Value = fechaInicial;

            MySqlParameter paramFechaFinal = new MySqlParameter("@fecha_final", MySqlDbType.Date);
            paramFechaFinal.Direction = ParameterDirection.Input;
            paramFechaFinal.Value = fechaFinal;

            MySqlParameter paramNombreTrabajador = new MySqlParameter("@nombre_trabajador", MySqlDbType.VarChar, 100);
            paramNombreTrabajador.Direction = ParameterDirection.Input;
            paramNombreTrabajador.Value = nombreTrabajador;

            // Limpiar los parámetros anteriores y agregar los nuevos parámetros
            comando.Parameters.Clear();
            comando.Parameters.Add(paramFechaInicial);
            comando.Parameters.Add(paramFechaFinal);
            comando.Parameters.Add(paramNombreTrabajador);

            // Crear un adaptador y llenar el DataSet
            MySqlDataAdapter Adaptador = new MySqlDataAdapter(comando);
            DataSet Data = new DataSet();
            Adaptador.Fill(Data);
            Data.DataSetName = "DataSet1";

            // Configurar el ReportDataSource y el ReportViewer
            ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Reportes);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Lenovo\Desktop\Universidad\Analisis Y Modelado\Proyecto\Sistema Locatario\Sistema Locatario\REPORTE_PEDIDOS_POR_TRABAJADOR_NOMBRE.rdlc";

            reportViewer1.LocalReport.SetParameters(new ReportParameter("Fecha", fechahoy));
            reportViewer1.RefreshReport();
            conexion.Close();

        }

        private void cmdPedidoXClienteXEstado_Click(object sender, EventArgs e)
        {
            string nombreCliente = cboCliente.Text;
            string estado = txtEstado.Text.Trim().ToLower(); // Obtener el estado ingresado y convertirlo a minúsculas

            // Verificar que el estado ingresado sea válido
            if (estado != "r" && estado != "c")
            {
                MessageBox.Show("El estado ingresado no es válido. Por favor, ingrese 'r' para registrado o 'c' para cobrado.");
                return;
            }

            // Configurar el comando para llamar al procedimiento almacenado
            comando.CommandText = "REPORTE_PEDIDOS_POR_CLIENTE_Y_ESTADO";
            comando.CommandType = CommandType.StoredProcedure;

            // Crear los parámetros de cliente y estado
            MySqlParameter paramCliente = new MySqlParameter("@cliente", MySqlDbType.VarChar, 50);
            paramCliente.Direction = ParameterDirection.Input;
            paramCliente.Value = nombreCliente;

            MySqlParameter paramEstado = new MySqlParameter("@statu", MySqlDbType.VarChar, 1);
            paramEstado.Direction = ParameterDirection.Input;
            paramEstado.Value = estado;

            // Limpiar los parámetros anteriores y agregar los nuevos parámetros
            comando.Parameters.Clear();
            comando.Parameters.Add(paramCliente);
            comando.Parameters.Add(paramEstado);

            // Crear un adaptador y llenar el DataSet
            MySqlDataAdapter Adaptador = new MySqlDataAdapter(comando);
            DataSet Data = new DataSet();
            Adaptador.Fill(Data);
            Data.DataSetName = "DataSet1";

            // Configurar el ReportDataSource y el ReportViewer
            ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Reportes);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Lenovo\Desktop\Universidad\Analisis Y Modelado\Proyecto\Sistema Locatario\Sistema Locatario\REPORTE_PEDIDOS_POR_CLIENTE_Y_ESTADO.rdlc";

            reportViewer1.LocalReport.SetParameters(new ReportParameter("Fecha", fechahoy));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Nombre", nombreCliente));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Estado", estado));
            reportViewer1.RefreshReport();
            conexion.Close();
        }


        private void cmdPedidoXCliente_Click(object sender, EventArgs e)
        {
            string nombreCliente = cboCliente.Text;

            // Configurar el comando para llamar al procedimiento almacenado
            comando.CommandText = "REPORTE_PEDIDOS_DETALLE";
            comando.CommandType = CommandType.StoredProcedure;

            // Crear el parámetro NombreCliente y asignarle el valor del ComboBox
            MySqlParameter paramNombreCliente = new MySqlParameter("@nombre_cliente", MySqlDbType.VarChar, 100);
            paramNombreCliente.Direction = ParameterDirection.Input;
            paramNombreCliente.Value = nombreCliente;

            // Limpiar los parámetros anteriores y agregar el nuevo parámetro
            comando.Parameters.Clear();
            comando.Parameters.Add(paramNombreCliente);

            // Crear un adaptador y llenar el DataSet
            MySqlDataAdapter Adaptador = new MySqlDataAdapter(comando);
            DataSet Data = new DataSet();
            Adaptador.Fill(Data);
            Data.DataSetName = "DataSet1";

            // Configurar el ReportDataSource y el ReportViewer
            ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Reportes);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Lenovo\Desktop\Universidad\Analisis Y Modelado\Proyecto\Sistema Locatario\Sistema Locatario\REPORTE_PEDIDOS_DETALLErdlc.rdlc";
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Fecha", fechahoy));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Nombre", nombreCliente));
            reportViewer1.RefreshReport();
            conexion.Close();

        }

        private void cmdFrutasVerdVendidas_Click(object sender, EventArgs e)
        {
            // Obtener las fechas de inicio y fin desde tus controles de fecha o cualquier otra fuente
            string fechaInicial = DTFA.Value.ToString("yyyy-MM-dd");
            string fechaFinal = DTFB.Value.ToString("yyyy-MM-dd");

            // Configurar el comando para llamar al procedimiento almacenado
            comando.CommandText = "REPORTE_FRUTAS_VERDURAS_MAS_VENDIDAS_TODOS";
            comando.CommandType = CommandType.StoredProcedure;

            // Crear los parámetros para las fechas y asignarles sus valores
            MySqlParameter paramFechaInicio = new MySqlParameter("@fecha_inicio", MySqlDbType.Date);
            paramFechaInicio.Direction = ParameterDirection.Input;
            paramFechaInicio.Value = fechaInicial;

            MySqlParameter paramFechaFin = new MySqlParameter("@fecha_fin", MySqlDbType.Date);
            paramFechaFin.Direction = ParameterDirection.Input;
            paramFechaFin.Value = fechaFinal;

            // Limpiar los parámetros anteriores y agregar los nuevos parámetros
            comando.Parameters.Clear();
            comando.Parameters.Add(paramFechaInicio);
            comando.Parameters.Add(paramFechaFin);

            // Crear un adaptador y llenar el DataSet
            MySqlDataAdapter Adaptador = new MySqlDataAdapter(comando);
            DataSet Data = new DataSet();
            Adaptador.Fill(Data);
            Data.DataSetName = "DataSet1";

            // Configurar el ReportDataSource y el ReportViewer
            ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Reportes);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Lenovo\Desktop\Universidad\Analisis Y Modelado\Proyecto\Sistema Locatario\Sistema Locatario\REPORTE_FRUTAS_VERDURAS_MAS_VENDIDAS_TODOS.rdlc";

           
    
            reportViewer1.RefreshReport();
            conexion.Close();

        }

        private void cmdCobroPedido_Click(object sender, EventArgs e)
        {
            // Obtener las fechas de inicio y fin desde tus controles de fecha o cualquier otra fuente
            string fechaInicial = DTFA.Value.ToString("yyyy-MM-dd");
            string fechaFinal = DTFB.Value.ToString("yyyy-MM-dd");

            // Configurar el comando para llamar al procedimiento almacenado
            comando.CommandText = "REPORTE_COBROS_POR_PERIODO";
            comando.CommandType = CommandType.StoredProcedure;

            // Crear los parámetros para las fechas y asignarles sus valores
            MySqlParameter paramFechaInicio = new MySqlParameter("@fecha_inicio", MySqlDbType.Date);
            paramFechaInicio.Direction = ParameterDirection.Input;
            paramFechaInicio.Value = fechaInicial;

            MySqlParameter paramFechaFin = new MySqlParameter("@fecha_fin", MySqlDbType.Date);
            paramFechaFin.Direction = ParameterDirection.Input;
            paramFechaFin.Value = fechaFinal;

            // Limpiar los parámetros anteriores y agregar los nuevos parámetros
            comando.Parameters.Clear();
            comando.Parameters.Add(paramFechaInicio);
            comando.Parameters.Add(paramFechaFin);

            // Crear un adaptador y llenar el DataSet
            MySqlDataAdapter Adaptador = new MySqlDataAdapter(comando);
            DataSet Data = new DataSet();
            Adaptador.Fill(Data);
            Data.DataSetName = "DataSet1";

            // Configurar el ReportDataSource y el ReportViewer
            ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Reportes);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Lenovo\Desktop\Universidad\Analisis Y Modelado\Proyecto\Sistema Locatario\Sistema Locatario\REPORTE_COBROS_POR_PERIODO.rdlc";

            reportViewer1.LocalReport.SetParameters(new ReportParameter("FechaInicio", fechaInicial));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("FechaFinal", fechaFinal));

            reportViewer1.RefreshReport();
            conexion.Close();

        }

        private void cmdSalario_Click(object sender, EventArgs e)
        {
            // Obtener los valores necesarios, como el nombre del trabajador y las fechas de inicio y fin
            string nombreTrabajador = CboTrabajador2.Text;
            string fechaInicial = DTFA.Value.ToString("yyyy-MM-dd");
            string fechaFinal = DTFB.Value.ToString("yyyy-MM-dd");

            // Configurar el comando para llamar al procedimiento almacenado
            comando.CommandText = "REPORTE_SALARIOS_POR_TRABAJADOR_Y_PERIODO";
            comando.CommandType = CommandType.StoredProcedure;

            // Crear los parámetros para el nombre del trabajador, fecha de inicio y fecha de fin
            MySqlParameter paramNombreTrabajador = new MySqlParameter("@nombre_trabajador", MySqlDbType.VarChar, 100);
            paramNombreTrabajador.Direction = ParameterDirection.Input;
            paramNombreTrabajador.Value = nombreTrabajador;

            MySqlParameter paramFechaInicio = new MySqlParameter("@fecha_inicio", MySqlDbType.Date);
            paramFechaInicio.Direction = ParameterDirection.Input;
            paramFechaInicio.Value = fechaInicial;

            MySqlParameter paramFechaFin = new MySqlParameter("@fecha_fin", MySqlDbType.Date);
            paramFechaFin.Direction = ParameterDirection.Input;
            paramFechaFin.Value = fechaFinal;

            // Limpiar los parámetros anteriores y agregar los nuevos parámetros
            comando.Parameters.Clear();
            comando.Parameters.Add(paramNombreTrabajador);
            comando.Parameters.Add(paramFechaInicio);
            comando.Parameters.Add(paramFechaFin);

            // Crear un adaptador y llenar el DataSet
            MySqlDataAdapter Adaptador = new MySqlDataAdapter(comando);
            DataSet Data = new DataSet();
            Adaptador.Fill(Data);
            Data.DataSetName = "DataSet1";

            // Configurar el ReportDataSource y el ReportViewer
            ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Reportes);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Lenovo\Desktop\Universidad\Analisis Y Modelado\Proyecto\Sistema Locatario\Sistema Locatario\REPORTE_SALARIOS_POR_TRABAJADOR_Y_PERIODO.rdlc";

            reportViewer1.LocalReport.SetParameters(new ReportParameter("FechaInicio", fechaInicial));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("FechaFinal", fechaFinal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Trabajador", nombreTrabajador));
            reportViewer1.RefreshReport();
            conexion.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del producto desde tu formulario
            string nombreProducto = cboConcepto.Text;

            // Configurar el comando para llamar al procedimiento almacenado
            comando.CommandText = "REPORTE_VIAJES_POR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;

            // Crear el parámetro para el nombre del producto y asignarle el valor obtenido del formulario
            MySqlParameter paramNombreProducto = new MySqlParameter("@nombreProducto", MySqlDbType.VarChar, 50);
            paramNombreProducto.Direction = ParameterDirection.Input;
            paramNombreProducto.Value = nombreProducto;

            // Limpiar los parámetros anteriores y agregar el nuevo parámetro
            comando.Parameters.Clear();
            comando.Parameters.Add(paramNombreProducto);

            // Crear un adaptador y llenar el DataSet
            MySqlDataAdapter Adaptador = new MySqlDataAdapter(comando);
            DataSet Data = new DataSet();
            Adaptador.Fill(Data);
            Data.DataSetName = "DataSet1";

            // Configurar el ReportDataSource y el ReportViewer
            ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Reportes);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Lenovo\Desktop\Universidad\Analisis Y Modelado\Proyecto\Sistema Locatario\Sistema Locatario\REPORTE_VIAJES_POR_PRODUCTO.rdlc";
            reportViewer1.RefreshReport();
            conexion.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del trabajador desde tu formulario
            string nombreTrabajador = cboTrabajadoresChoferes.Text;

            // Configurar el comando para llamar al procedimiento almacenado
            comando.CommandText = "REPORTE_VIAJES_POR_TRABAJADOR";
            comando.CommandType = CommandType.StoredProcedure;

            // Crear el parámetro para el nombre del trabajador y asignarle el valor obtenido del formulario
            MySqlParameter paramNombreTrabajador = new MySqlParameter("@nombreTrabajador", MySqlDbType.VarChar, 50);
            paramNombreTrabajador.Direction = ParameterDirection.Input;
            paramNombreTrabajador.Value = nombreTrabajador;

            // Limpiar los parámetros anteriores y agregar el nuevo parámetro
            comando.Parameters.Clear();
            comando.Parameters.Add(paramNombreTrabajador);

            // Crear un adaptador y llenar el DataSet
            MySqlDataAdapter Adaptador = new MySqlDataAdapter(comando);
            DataSet Data = new DataSet();
            Adaptador.Fill(Data);
            Data.DataSetName = "DataSet1";

            // Configurar el ReportDataSource y el ReportViewer
            ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Reportes);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Lenovo\Desktop\Universidad\Analisis Y Modelado\Proyecto\Sistema Locatario\Sistema Locatario\REPORTE_VIAJES_POR_TRABAJADOR.rdlc";

            reportViewer1.LocalReport.SetParameters(new ReportParameter("Fecha", fechahoy));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Trabajador", nombreTrabajador)); ;
            reportViewer1.RefreshReport();
            conexion.Close();

        }
    }
}
