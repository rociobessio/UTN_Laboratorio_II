using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_04_SobreCarg_Ejercicio_A01;

namespace Unidad_05_WinForm_Ejercicio_C02
{
    public partial class FrmVulcano : Form
    {
        Fahrenheit fahr;
        Celsius cel;
        Kelvin kelv;

        public FrmVulcano()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;//no ppoder ajustarlo
            this.MaximizeBox = false;//no poder maximixar
            this.MinimizeBox = false;//no poder minimizar


            this.txtCelACel.Enabled = false;
            this.txtCelAKelv.Enabled = false;
            this.txtCelsiusAFahr.Enabled = false;
            this.txtFahrAKel.Enabled = false;
            this.txtFahrenheitACelsius.Enabled = false;
            this.txtFahrenheitAFahrenheit.Enabled = false;
            this.txtKelACel.Enabled = false;
            this.txtKelvAKelv.Enabled = false;
            this.txtKelvinAFahr.Enabled = false;
        }

        private void FrmVulcano_Load(object sender, EventArgs e)
        {
            this.Text = "Vulcano";
            fahr = new Fahrenheit(0);
            cel = new Celsius(0);
            kelv = new Kelvin(0);

            //asigno el valor de fahrenhit y lo paso a string para imprimirlo en los textboxes
            txtFahrenheit.Text = fahr.valor.ToString();
            txtCelsius.Text = cel.valor.ToString();
            txtKelvin.Text = kelv.valor.ToString();

        }

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {
            //Intento parsear lo ingresado en el textbox de fahr y le asigno el valor a fahr
            int.TryParse(txtFahrenheit.Text,out fahr.valor);
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            //Intento parsear lo ingresado en el textbox de celsius y le asigno el valor a cel
            int.TryParse(txtCelsius.Text, out cel.valor);
        }

        private void txtKelvin_TextChanged(object sender, EventArgs e)
        {
            //Intento parsear lo ingresado en el textbox de kelvin y le asigno el valor a kelv
            int.TryParse(txtKelvin.Text, out kelv.valor);
        }

        private void btnConvertFahrenhit_Click(object sender, EventArgs e)
        {
            txtFahrenheitAFahrenheit.Text = fahr.valor.ToString();
            txtFahrenheitACelsius.Text = fahr.ACelsius().ToString();
            txtFahrAKel.Text = fahr.AKelvin().ToString();
        }

        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            txtCelACel.Text = cel.valor.ToString();
            txtCelAKelv.Text = cel.AKelvin().ToString();
            txtCelsiusAFahr.Text = cel.AFarenheit().ToString();
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            txtKelvAKelv.Text = kelv.valor.ToString();
            txtKelACel.Text = kelv.ACelsius().ToString();
            txtKelvinAFahr.Text = kelv.AFahrenheit().ToString();
            
        }

        private void txtKelACel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
