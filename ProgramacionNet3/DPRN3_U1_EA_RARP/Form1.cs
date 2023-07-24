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
        SqlConnection RRPSqlConnection;
        SqlDataAdapter RRPDataAdapter;
        DataSet RRPDataSet;
        string cadenaConexion = "Data Source = LAPTOP-AVRBQCPP\\SQLEXPRESS; Initial Catalog = RRPdbProveedores; Integrated Security = True";

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            try{
                using (RRPSqlConnection = new SqlConnection(cadenaConexion))
                {
                    RRPSqlConnection.Open();
                    ConsultaProvedores();
                    RRPSqlConnection.Close();
                }
            }
            catch(Exception ex){
                MessageBox.Show("No se puede conectar a la base de datos" + ex.Message);
            }
        }

        private void ConsultaProvedores()
        {
            RRPDataAdapter = new SqlDataAdapter("select * from RRPProvedores", RRPSqlConnection);
            RRPDataSet = new DataSet();
            RRPDataAdapter.Fill(RRPDataSet,"proveedores");
            dgvProvedores.DataSource = RRPDataSet;
            dgvProvedores.DataMember = "proveedores";
            /*
            dgvProvedores.Columns["Id_proveedor"].HeaderText = "Id";
            dgvProvedores.Columns["Nombre"].HeaderText = "Nombre";
            dgvProvedores.Columns["ApellidoPaterno"].HeaderText = "Descripcion";
            */
        }
    }
}
