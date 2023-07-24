using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DPRN3_U1_EA_RARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Objetos para realizar la conexión con la base de datos, así como el DataAdapter y DataSer
        SqlConnection RRPSqlConnection;
        SqlDataAdapter RRPDataAdapter;
        DataSet RRPDataSet;
        //string que contiene la conexión para la base de datos, como la dirección de la base de datos, el nombre a que conectarse y en algunos casos el uso de el usuario y contraseña
        string cadenaConexion = "Data Source = LAPTOP-AVRBQCPP\\SQLEXPRESS; Initial Catalog = RRPdbProveedores; Integrated Security = True";
        //string cadenaConexion = "Data Source = 203.162.23.56; Initial Catalog = RRPdbProveedores; Integrated Security = True";
        //Método que se activa cuando se acciona click a un botón, la función del botón es mostrar los provedores
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            //Uso del try/catch para el caso de que se realice exitosamente la conexión
            try{
                using (RRPSqlConnection = new SqlConnection(cadenaConexion))
                {
                    RRPSqlConnection.Open();
                    ConsultaProvedores();
                    RRPSqlConnection.Close();
                }
            }
            //Mensaje para el caso de que no se haya realizado de manera correcta la conexión
            catch(Exception ex){
                MessageBox.Show("No se puede conectar a la base de datos" + ex.Message);
            }
        }
        //Método que permite la consulta de los proveedores
        private void ConsultaProvedores()
        {
            //Uso del DataAdapter de los datos obtenidos de la consulta SQL
            RRPDataAdapter = new SqlDataAdapter("select * from RRPProvedores", RRPSqlConnection);
            //Instanciamiento del DataSet
            RRPDataSet = new DataSet();
            //LLenado del DataAdapter con el nombre de proveedores
            RRPDataAdapter.Fill(RRPDataSet,"proveedores");
            //Uso del obejeto del DataGridView para llenar la información obtenida de la base de datos
            dgvProvedores.DataSource = RRPDataSet;
            dgvProvedores.DataMember = "proveedores";
        }
        //Método que se activa cuando se acciona click a un botón, la función del botón es mostrar las auto partes
        private void btnAutoPartes_Click(object sender, EventArgs e)
        {
            //Uso del try/catch para el caso de que se realice exitosamente la conexión
            try
            {
                using (RRPSqlConnection = new SqlConnection(cadenaConexion))
                {
                    RRPSqlConnection.Open();
                    ConsultaAutoPartes();
                    RRPSqlConnection.Close();
                }
            }
            //Mensaje para el caso de que no se haya realizado de manera correcta la conexión
            catch (Exception ex)
            {
                MessageBox.Show("No se puede conectar a la base de datos" + ex.Message);
            }
        }
        //Método que permite la consulta de auto partes
        private void ConsultaAutoPartes()
        {
            //Uso del DataAdapter de los datos obtenidos de la consulta SQL
            RRPDataAdapter = new SqlDataAdapter("select * from RRPAutopartes", RRPSqlConnection);
            //Instanciamiento del DataSet
            RRPDataSet = new DataSet();
            //LLenado del DataAdapter con el nombre de autopartes
            RRPDataAdapter.Fill(RRPDataSet, "autopartes");
            //Uso del obejeto del DataGridView para llenar la información obtenida de la base de datos
            dgvAutoPartes.DataSource = RRPDataSet;
            dgvAutoPartes.DataMember = "autopartes";
        }
        //Método que se activa cuando se acciona click a un botón, la función del botón es mostrar el detalle de compra
        private void btnDetalleCompra_Click(object sender, EventArgs e)
        {
            //Uso del try/catch para el caso de que se realice exitosamente la conexión
            try
            {
                using (RRPSqlConnection = new SqlConnection(cadenaConexion))
                {
                    RRPSqlConnection.Open();
                    ConsultaADetalleCompra();
                    RRPSqlConnection.Close();
                }
            }
            //Mensaje para el caso de que no se haya realizado de manera correcta la conexión
            catch (Exception ex)
            {
                MessageBox.Show("No se puede conectar a la base de datos" + ex.Message);
            }
        }
        //Método que permite la consulta del detalle de compra de la autoparte
        private void ConsultaADetalleCompra()
        {
            //Uso del DataAdapter de los datos obtenidos de la consulta SQL
            RRPDataAdapter = new SqlDataAdapter("select * from RRPDetalleCompra", RRPSqlConnection);
            //Instanciamiento del DataSet
            RRPDataSet = new DataSet();
            //LLenado del DataAdapter con el nombre de detalles
            RRPDataAdapter.Fill(RRPDataSet, "detalles");
            //Uso del obejeto del DataGridView para llenar la información obtenida de la base de datos
            dgvDetalleCompra.DataSource = RRPDataSet;
            dgvDetalleCompra.DataMember = "detalles";
        }
    }
}
