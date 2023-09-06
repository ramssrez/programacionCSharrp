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

namespace DSDPRN3RRP2302B1
{
    public partial class Pacientes : Form
    {
        private MySqlDataAdapter adapterRRP;
        private DataTable dataTableRRP;
        public Pacientes()
        {
            InitializeComponent();
        }

        private void BtnGuardarRRP_Click(object sender, EventArgs e)
        {
            String s = "";
            int numero = 0;
            if (RgbFemeninoRRP.Checked)
            {
                s = RgbFemeninoRRP.Text;
                numero = RgbFemeninoRRP.TabIndex+1;
               
            }else if (RgbMasculinoRRP.Checked)
            {
                s = RgbMasculinoRRP.Text;
                numero = RgbMasculinoRRP.TabIndex+1;
            }
            Console.WriteLine($"Botón: {BtnGuardarRRP.Text}\nSexo: {s}\nEstado Civil:{CbxEdoCivilRRP.Items[CbxEdoCivilRRP.SelectedIndex]}\nNombre: {TxtNombreCRRP.Text}\nApellidos: {TxtApellidoCRRP.Text}");
            Console.WriteLine($"Edad: {TxtEdadCRRP.Text}\nCalle: {TxtCalleCRRP.Text}\nEstado: {TxtEstadoCRRP.Text}\nCiudad: {TxtCiudadCRRP.Text}\nCódigo Postal: {TxtCodigoPostalCRRP.Text}");
            Console.WriteLine($"Fijo: {TxtTelefonoFijoCRRP.Text}\nCelular: {TxtTelefonoCelularCRRP.Text}\nEmail: {TxtEmailCRRP.Text}");
            Console.WriteLine($"{CbxEdoCivilRRP.Items[CbxEdoCivilRRP.SelectedIndex]}, {CbxEdoCivilRRP.SelectedIndex+1}");
            Console.WriteLine($"Sexo: {numero}");
        }

        private void BtnActualizarRRP_Click(object sender, EventArgs e)
        {
            String s = "";
            if (RgbFemeninoRRP.Checked)
            {
                s = RgbFemeninoRRP.Text;
            }
            else if (RgbMasculinoRRP.Checked)
            {
                s = RgbMasculinoRRP.Text;
            }
            Console.WriteLine($"Botón: {BtnActualizarRRP.Text}\nSexo: {s}\nEstado Civil:{CbxEdoCivilRRP.Items[CbxEdoCivilRRP.SelectedIndex]}\nNombre: {TxtNombreCRRP.Text}\nApellidos: {TxtApellidoCRRP.Text}");
            Console.WriteLine($"Edad: {TxtEdadCRRP.Text}\nCalle: {TxtCalleCRRP.Text}\nEstado: {TxtEstadoCRRP.Text}\nCiudad: {TxtCiudadCRRP.Text}\nCódigo Postal: {TxtCodigoPostalCRRP.Text}");
            Console.WriteLine($"Fijo: {TxtTelefonoFijoCRRP.Text}\nCelular: {TxtTelefonoCelularCRRP.Text}\nEmail: {TxtEmailCRRP.Text}");
        }

        private void BtnEliminarRRP_Click(object sender, EventArgs e)
        {
            String s = "";
            if (RgbFemeninoRRP.Checked)
            {
                s = RgbFemeninoRRP.Text;
            }
            else if (RgbMasculinoRRP.Checked)
            {
                s = RgbMasculinoRRP.Text;
            }
            Console.WriteLine($"Botón: {BtnEliminarRRP.Text}\nSexo: {s}\nEstado Civil:{CbxEdoCivilRRP.Items[CbxEdoCivilRRP.SelectedIndex]}\nNombre: {TxtNombreCRRP.Text}\nApellidos: {TxtApellidoCRRP.Text}");
            Console.WriteLine($"Edad: {TxtEdadCRRP.Text}\nCalle: {TxtCalleCRRP.Text}\nEstado: {TxtEstadoCRRP.Text}\nCiudad: {TxtCiudadCRRP.Text}\nCódigo Postal: {TxtCodigoPostalCRRP.Text}");
            Console.WriteLine($"Fijo: {TxtTelefonoFijoCRRP.Text}\nCelular: {TxtTelefonoCelularCRRP.Text}\nEmail: {TxtEmailCRRP.Text}");

        }

        private void BtnConexionRRP_Click(object sender, EventArgs e)
        {
            DoctoresConsulta();
        }

        private void DoctoresConsulta()
        {
            string sqlRRP = $"SELECT idPacientes as Id, Nombre, ApellidoMaterno as 'Apellido Paterno', ApellidoMaterno as 'Apellido Materno', Direccion, Celular, TelefonoFijo as 'Telefono Fijo', Edad, Sexo, EstadoCivil as 'Estado Civil' FROM tbpacientesrrp";
            MySqlConnection conexionDBRRP = Conexion.conexion();
            try
            {
                conexionDBRRP.Open();
                adapterRRP = new MySqlDataAdapter(sqlRRP, conexionDBRRP);
                dataTableRRP = new DataTable();
                adapterRRP.Fill(dataTableRRP);
                DtWConexionRRP.DataSource = dataTableRRP;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al buscar doctores: {ex.Message}");
            }
            finally
            {
                conexionDBRRP.Close();
            }
        }
    }
}
