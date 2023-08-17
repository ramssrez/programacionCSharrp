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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuardarRRP_Click(object sender, EventArgs e)
        {
            String s = "";
            if (RgbFemeninoRRP.Checked)
            {
                s = RgbFemeninoRRP.Text;
            }else if (RgbMasculinoRRP.Checked)
            {
                s = RgbMasculinoRRP.Text;
            }
            Console.WriteLine($"Botón: {BtnGuardarRRP.Text}\nSexo: {s}\nEstado Civil:{CbxEdoCivilRRP.Items[CbxEdoCivilRRP.SelectedIndex]}\nNombre: {TxtNombreCRRP.Text}\nApellidos: {TxtApellidoCRRP.Text}");
            Console.WriteLine($"Edad: {TxtEdadCRRP.Text}\nCalle: {TxtCalleCRRP.Text}\nEstado: {TxtEstadoCRRP.Text}\nCiudad: {TxtCiudadCRRP.Text}\nCódigo Postal: {TxtCodigoPostalCRRP.Text}");
            Console.WriteLine($"Fijo: {TxtTelefonoFijoCRRP.Text}\nCelular: {TxtTelefonoCelularCRRP.Text}\nEmail: {TxtEmailCRRP.Text}");
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
    }
}
