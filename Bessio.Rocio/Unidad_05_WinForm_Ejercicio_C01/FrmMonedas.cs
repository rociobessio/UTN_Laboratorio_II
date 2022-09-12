using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Unidad_05_WinForm_Ejercicio_C01
{
    public partial class FrmMonedas : Form
    {
        #region ATRIBUTOS 
        private bool lockedImage;
        Dolar dolar;
        Euro euro;
        Peso peso;

        #endregion

        public FrmMonedas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            txtDolarADolar.Enabled = false;
            txtDolarAEuro.Enabled = false;
            txtDolarAPeso.Enabled = false;
            txtEuroAEuro.Enabled = false;
            txtEuroADolar.Enabled = false;
            txtEuroAPeso.Enabled = false;
            txtPesoAPeso.Enabled = false;
            txtPesoAEuro.Enabled = false;
            txtPesoADolar.Enabled = false;
        }

        private void FrmMonedas_Load(object sender, EventArgs e)
        {
            this.Text = "Cotización";
            lockedImage = true;
            dolar = new Dolar(0);
            euro = new Euro(0);
            peso = new Peso(0);

            #region OBTENGO EL VALOR INGRESADO
            txtDolar.Text = dolar.GetCantidad.ToString();
            txtEuro.Text = euro.GetCantidad.ToString();
            txtPeso.Text = peso.GetCantidad.ToString();
            #endregion

            txtCotizacionDolar.Text = Dolar.GetCotizacion.ToString();
            txtCotizacionEuro.Text = Euro.GetCotizacion.ToString();
            txtCotizacionPeso.Text = Peso.GetCotizacion.ToString();

        }

        private void txtEuro_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            double.TryParse(txtEuro.Text,out aux);
            euro = new Euro(aux);
        }

        private void txtDolar_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            double.TryParse(txtDolar.Text, out aux);
            dolar = new Dolar(aux);
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            double.TryParse(txtPeso.Text, out aux);
            peso = new Peso(aux);
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            txtEuroAEuro.Text = euro.GetCantidad.ToString();//Obtengo la cant de euro
            txtEuroADolar.Text = euro.GetCantidad.ToString();
            txtEuroAPeso.Text = ((Peso)euro).GetCantidad.ToString();
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {//((NumeroBinario)((NumeroDecimal)auxiliar)).numero;
            this.txtDolarADolar.Text = dolar.GetCantidad.ToString();
            this.txtDolarAEuro.Text = Dolar.GetCotizacion.ToString();
            txtDolarAPeso.Text = Dolar.GetCotizacion.ToString();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (lockedImage == true)
            {
                txtCotizacionDolar.ReadOnly = true;
                txtCotizacionEuro.ReadOnly = true;
                txtCotizacionPeso.ReadOnly = true;
                lockedImage = false;
            }
            else
            {
                txtCotizacionDolar.ReadOnly = false;
                txtCotizacionEuro.ReadOnly = false;
                txtCotizacionPeso.ReadOnly = false;
                lockedImage = true;
            }
        }
    }
}
