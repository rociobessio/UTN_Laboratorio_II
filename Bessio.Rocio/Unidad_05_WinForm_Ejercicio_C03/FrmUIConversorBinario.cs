using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_05_WinForm_Ejercicio_C03
{
    public partial class FrmUIConversorBinario : Form
    {
        public FrmUIConversorBinario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmUIConversorBinario_Load(object sender, EventArgs e)
        {
            this.Text = "Conversor Binario";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txtDecABinConvert.Enabled = false;
            txtBinADecCovert.Enabled = false;

        }

        private void btnBinADec_Click(object sender, EventArgs e)
        {
            this.txtBinADecCovert.Text = ((NumeroDecimal)((NumeroBinario)this.txBinIngresado.Text)).numero.ToString();//Devolvera numero binario
        }

        private void btnDecABin_Click(object sender, EventArgs e)
        {
            double auxiliar;
            if(double.TryParse(this.txtDecIngresado.Text,out auxiliar)){
                this.txtDecABinConvert.Text = ((NumeroBinario)((NumeroDecimal)auxiliar)).numero;
            }
            else
            {
                this.txtDecABinConvert.Text = "Error de datos"; 
            }
        }

        private void frmCerrar(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del formulario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
